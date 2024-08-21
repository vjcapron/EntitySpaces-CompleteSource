﻿/*  New BSD License
-------------------------------------------------------------------------------
Copyright (c) 2006-2012, EntitySpaces, LLC
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the EntitySpaces, LLC nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL EntitySpaces, LLC BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
-------------------------------------------------------------------------------
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Windows.Forms;

using Microsoft.Win32;

using EntitySpaces.Common;
using EntitySpaces.AddIn.TemplateUI;
using EntitySpaces.CodeGenerator;
using EntitySpaces.MetadataEngine;

namespace EntitySpaces.AddIn
{
    internal partial class ucProjects : esUserControl
    {
        private string projectName;
        private esProject project;
        private MostRecentlyUsedList mru;
        private bool isDirty = false;

        public ucProjects()
        {
            try
            {
                InitializeComponent();
            }
            catch { }
        }

        private void ucProjects_Load(object sender, EventArgs e)
        {
            try
            {
                if (!DesignMode)
                {
                    this.mru = new MostRecentlyUsedList();

                    this.tree.LoadTemplates(null, null, Settings);

                    try
                    {
                        this.projectTree.SelectedNode = this.projectTree.Nodes[0];
                    }
                    catch { }

                    LoadMruList();
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void LoadMruList()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\EntitySpaces 2012", false))
            {
                if (key == null) return;

                mru.Load(key, "Project_");
                PopulateMruMenu();
            }
        }

        private void SaveMruList()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\EntitySpaces 2012", true))
            {
                if (key == null) return;

                mru.Save(key, "Project_");
                PopulateMruMenu();
            }
        }

        private void PopulateMruMenu()
        {
            this.menuMRU.Items.Clear();

            foreach (string project in mru)
            {
                if (project == null) continue;

                try
                {
                    FileInfo info = new FileInfo(project);
                    ToolStripItem item = this.menuMRU.Items.Add(info.Name);
                    item.ToolTipText = project;
                    item.Image = Resource.check;
                }
                catch { }
            }
        }

        public override void OnSettingsChanged()
        {
      
        }

        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainWindow.HideErrorOrStatusMessage();

                splitContainer.Panel1Collapsed = true;
                splitContainer.Panel2Collapsed = false;

                EnableToolbarButtons(false);
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void buttonRecordOk_Click(object sender, EventArgs e)
        {
            Cursor origCursor = this.Cursor;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                this.MainWindow.HideErrorOrStatusMessage();

                TemplateDisplaySurface templateDisplaySurface = new TemplateDisplaySurface();

                Template template = this.tree.SelectedNode.Tag as Template;
                templateDisplaySurface.DisplayTemplateUI(false, null, this.Settings, template, OnExecute, OnCancel);

                splitContainer.Panel1Collapsed = false;
                splitContainer.Panel2Collapsed = true;
                isDirty = true;
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
            finally
            {
                EnableToolbarButtons(true);

                this.Cursor = origCursor;
            }
        }

        private void buttonRecordCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainWindow.HideErrorOrStatusMessage();

                splitContainer.Panel1Collapsed = false;
                splitContainer.Panel2Collapsed = true;

                EnableToolbarButtons(true);
                isDirty = false;
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void EnableToolbarButtons(bool enable)
        {
            this.ButtonProjectOpen.Enabled = enable;

            if (this.projectName != null)
            {
                this.ButtonSave.Enabled = enable;
            }
            this.ButtonSaveAs.Enabled = enable;
            this.ButtonExecute.Enabled = enable;
            this.ButtonClear.Enabled = enable;
            this.ButtonOpenFolder.Enabled = enable;
            this.ButtonMoveDown.Enabled = enable;
            this.ButtonMoveUp.Enabled = enable;

            if (enable == true)
            {
                TreeNode node = this.projectTree.SelectedNode;

                if (node != null)
                {
                    ProjectNodeData data = node.Tag as ProjectNodeData;

                    if (data != null)
                    {
                        this.ButtonRecord.Enabled = enable;
                    }
                }
            }
            else
            {
                this.ButtonRecord.Enabled = enable;
            }
        }

        private void ProjectTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                this.MainWindow.HideErrorOrStatusMessage();

                if (e.Button == MouseButtons.Right)
                {
                    TreeNode node = this.projectTree.GetNodeAt(e.X, e.Y);

                    if (node != null)
                    {
                        this.projectTree.SelectedNode = node;
                    }
                }
                else
                {
                    if (e.Node != null && e.Node.ImageIndex == 2)
                    {
                        this.ButtonRecord.Enabled = false;
                    }
                    else
                    {
                        this.ButtonRecord.Enabled = true;
                    }

                    this.ButtonExecute.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void ProjectTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;

                if (node != null)
                {
                    if (node.ImageIndex == 2)
                    {
                        this.ButtonRecord.Enabled = false;
                    }
                    else
                    {
                        this.ButtonRecord.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            AddFolder("Folder", true);
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainWindow.HideErrorOrStatusMessage();

                TreeNode node = this.projectTree.SelectedNode;

                if (node != null && node != this.projectTree.Nodes[0])
                {
                    node.Remove();
                    isDirty = true;
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void EditTemplatesMenuItem_Click(object sender, EventArgs e)
        {
            Cursor origCursor = this.Cursor;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                this.MainWindow.HideErrorOrStatusMessage();

                TemplateDisplaySurface templateDisplaySurface = new TemplateDisplaySurface();

                TreeNode node = this.projectTree.SelectedNode;

                ProjectNodeData data = node.Tag as ProjectNodeData;

                templateDisplaySurface.DisplayTemplateUI(true, data.Input, data.Settings as esSettings, data.Template, OnExecute, OnCancel);

                splitContainer.Panel1Collapsed = false;
                splitContainer.Panel2Collapsed = true;

                isDirty = true;
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
            finally
            {
                EnableToolbarButtons(true);

                this.Cursor = origCursor;
            }
        }

        private void EditSettingsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainWindow.HideErrorOrStatusMessage();

                TreeNode node = this.projectTree.SelectedNode;
                ProjectNodeData data = node.Tag as ProjectNodeData;

                PopupSettings popup = new PopupSettings();
                popup.Settings = (esSettings)data.Settings;

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    data.Settings = popup.Settings;
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void OnCancel(TemplateDisplaySurface surface)
        {

        }

        private void RenameMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainWindow.HideErrorOrStatusMessage();

                TreeNode node = this.projectTree.SelectedNode;

                if (node != null)
                {
                    node.BeginEdit();
                    isDirty = true;
                }

            }
            catch { }
        }

        private void ExecuteMenuItem_Click(object sender, EventArgs e)
        {
            Cursor origCursor = this.Cursor;
            bool error = false;

            try
            {
                this.MainWindow.HideErrorOrStatusMessage();

                this.Cursor = Cursors.WaitCursor;

                TreeNode node = this.projectTree.SelectedNode;

                if (node != null)
                {
                    MainWindow.HideErrorOrStatusMessage();
                    ExecuteRecordedTemplates(node);
                }
            }
            catch (Exception ex)
            {
                error = true;
                this.MainWindow.ShowError(ex);
            }
            finally
            {
                if (!error)
                {
                    MainWindow.ShowStatusMessage("Project Executed Successfully");
                }
                this.Cursor = origCursor;
            }

            try
            {
                if (isDirty) PromptForSave();
            }
            catch { }
        }

        private void ExecuteRecordedTemplates(TreeNode node)
        {
            try
            {
                 ExecuteRecordedTemplate(node);

                foreach (TreeNode childNode in node.Nodes)
                {
                    ExecuteRecordedTemplates(childNode);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ExecuteRecordedTemplate(TreeNode node)
        {
            try
            {
                if (node != null && node.Tag != null)
                {
                    ProjectNodeData tag = node.Tag as ProjectNodeData;

                    Root esMeta = esMetaCreator.Create(tag.Settings as esSettings);
                    esMeta.Input = tag.Input;

                    Template template = new Template();
                    template.Execute(esMeta, tag.Template.Header.FullFileName);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                buttonRecordOk.Enabled = this.tree.IsExecuteableTemplateSelected();
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private bool OnExecute(TemplateDisplaySurface surface)
        {
            try
            {
                if (surface.GatherUserInput())
                {
                    Hashtable ht = surface.CacheUserInput();

                    if (this.projectTree.SelectedNode != null && this.projectTree.SelectedNode.Tag != null)
                    {
                        ProjectNodeData tag = this.projectTree.SelectedNode.Tag as ProjectNodeData;
                        tag.Input = ht;
                    }
                    else
                    {
                        AddRecordedTemplate(surface, true);
                        isDirty = true;
                    }
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw;
                this.MainWindow.ShowError(ex);
                return false;
            }

            return true;
        }

        public void AddFolder(string name, bool beginEdit)
        {
            try
            {
                TreeNode node = this.projectTree.SelectedNode;

                if (node == null)
                {
                    node = this.projectTree.Nodes[0];
                }

                if (node != null)
                {
                    TreeNode folder = new TreeNode(name);
                    node.Nodes.Add(folder);
                    isDirty = true;

                    node.Expand();

                    this.projectTree.SelectedNode = folder;

                    if (beginEdit)
                    {
                        folder.BeginEdit();
                    }
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        public void AddRecordedTemplate(TemplateDisplaySurface surface, bool beginEdit)
        {
            try
            {
                TreeNode node = this.projectTree.SelectedNode;

                if (node == null)
                {
                    node = this.projectTree.Nodes[0];
                }

                if (node != null)
                {
                    TreeNode recordedTemplate = new TreeNode(surface.Template.Header.Title);
                    recordedTemplate.ImageIndex = 2;
                    recordedTemplate.SelectedImageIndex = 2;
                    recordedTemplate.ContextMenuStrip = menuTemplate;
                    node.Nodes.Add(recordedTemplate);

                    ProjectNodeData tag = new ProjectNodeData();
                    tag.Template = surface.Template;
                    tag.Input = surface.CacheUserInput();
                    tag.Settings = Settings.Clone();
                    recordedTemplate.Tag = tag;
        
                    node.Expand();
                    isDirty = true;

                    this.projectTree.SelectedNode = recordedTemplate;

                    if (beginEdit)
                    {
                        recordedTemplate.BeginEdit();
                    }
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        #region Drag Drop

        private void ProjectTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            try
            {
                TreeNode root = (TreeNode)e.Item;
                if (root == this.projectTree.Nodes[0]) return;

                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void ProjectTree_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Move;
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void ProjectTree_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Effect != DragDropEffects.Move) return;

                if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
                {
                    Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                    TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                    TreeNode NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                    if (DestinationNode == null) return;
                    if (DestinationNode.ImageIndex == 2) return;
                    if (NewNode == DestinationNode) return;

                    NewNode.Remove();
                    isDirty = true;

                    DestinationNode.Nodes.Add(NewNode);
                    DestinationNode.Expand();
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        #endregion

        private void ButtonProjectOpen_Click(object sender, EventArgs e)
        {
            Cursor oldCursor = Cursor.Current;
            isDirty = false;

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Open EntitySpaces Project File";
                openFileDialog.Filter = "Project Files (*.esprj)|*.esprj|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.OpenProject(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
            finally
            {
                Cursor.Current = oldCursor;
            }
        }

        private void ConvertProjectToTree(TreeNode parentNode, esProjectNode esNode)
        {
            TreeNode node = null;

            if (parentNode == null)
            {
                node = this.projectTree.Nodes.Add(esNode.Name);
            }
            else
            {
                node = parentNode.Nodes.Add(esNode.Name);
            }

            if(!esNode.IsFolder)
            {
                ProjectNodeData tag = new ProjectNodeData();
                tag.Template = esNode.Template;
                tag.Settings = esNode.Settings;
                tag.Input = esNode.Input;

                node.Tag = tag;
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
                node.ContextMenuStrip = menuTemplate;

                node.ToolTipText = esNode.Template.Header.Description + " (" + node.FullPath + ")";
            }

            foreach (esProjectNode childNode in esNode.Children)
            {
                ConvertProjectToTree(node, childNode);
            }
        }

        private void ConvertTreeToProject(esProjectNode esParentNode, TreeNode node)
        {
            esProjectNode esNode = new esProjectNode();
            esNode.Name = node.Text;

            if (esParentNode == null)
            {
                project.RootNode = esNode;
            }
            else
            {
                esParentNode.Children.Add(esNode);
            }

            if (node.Tag != null)
            {
                ProjectNodeData tag = node.Tag as ProjectNodeData;

                esNode.Template = tag.Template;
                esNode.Settings = tag.Settings;
                esNode.Input = tag.Input;

                esNode.IsFolder = false;
            }

            foreach (TreeNode childNode in node.Nodes)
            {
                ConvertTreeToProject(esNode, childNode);
            }
        }

        private void ButtonSaveAs_Click(object sender, EventArgs e)
        {
            Cursor oldCursor = Cursor.Current;

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save EntitySpaces Project File";
                saveFileDialog.Filter = "Project Files (*.esprj)|*.esprj|All Files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    this.SaveProject(saveFileDialog.FileName);

                    projectName = saveFileDialog.FileName;
                    this.ButtonSave.Enabled = true;

                    mru.Push(this.projectName);
                    SaveMruList();
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
            finally
            {
                Cursor.Current = oldCursor;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Cursor oldCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.SaveProject(this.projectName);
                this.OpenProject(this.projectName);
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
            finally
            {
                Cursor.Current = oldCursor;
            }
        }

        private void SaveProject(string fileNameAndPath)
        {
            TreeNode rootNode = this.projectTree.Nodes[0];

            project = new esProject();
            ConvertTreeToProject(project.RootNode, rootNode);
            project.Save(fileNameAndPath, MainWindow.Settings);
            project = null;
            isDirty = false;
        }

        private void OpenProject(string fileNameAndPath)
        {
            Cursor oldCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                esProject project = new esProject();
                project.Load(fileNameAndPath, MainWindow.Settings);

                this.projectTree.Nodes.Clear();
                ConvertProjectToTree(null, project.RootNode);

                this.ButtonSave.Enabled = true;

                this.projectName = fileNameAndPath;

                this.projectTree.ExpandAll();

                this.projectTree.SelectedNode = this.projectTree.Nodes[0];
                this.projectTree.Select();

                EnableToolbarButtons(true);

                mru.Push(this.projectName);
                SaveMruList();
            }
            catch (Exception ex)
            {
                mru.Remove(fileNameAndPath);
                this.SaveMruList();
                this.MainWindow.ShowError(ex);
            }
            finally
            {
                Cursor.Current = oldCursor;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.projectTree.Nodes.Clear();
                this.projectTree.Nodes.Add(new TreeNode("Project"));
                this.projectName = null;
                this.ButtonSave.Enabled = false;

                this.projectTree.SelectedNode = this.projectTree.Nodes[0];
                this.projectTree.Select();
                isDirty = false;

                EnableToolbarButtons(true);
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "explorer";
                p.StartInfo.Arguments = "/e," + Settings.OutputPath;
                p.StartInfo.UseShellExecute = true;
                p.Start();
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void expandAllMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.projectTree.SelectedNode != null)
                {
                    this.projectTree.SelectedNode.ExpandAll();
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void menuMRU_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                string project = e.ClickedItem.ToolTipText;
                this.mru.Remove(project);  // OpenProject will reinsert him at the top
                this.OpenProject(project);
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }

        private void CopyNodePath(object sender, EventArgs e)
        {
            if (this.projectTree.SelectedNode != null)
            {
                Clipboard.SetText(this.projectTree.SelectedNode.FullPath);
            }
        }

        private void MoveUpMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = this.projectTree.SelectedNode;

            if (node == null) return;

            TreeNode parent = node.Parent;
            TreeNode prevNode = node.PrevNode;

            if (prevNode == null) return;

            this.projectTree.BeginUpdate();

            int index = node.Index;
            int pIndex = node.PrevNode.Index;

            parent.Nodes.Remove(prevNode);

            parent.Nodes.Insert(index, prevNode);

            this.projectTree.SelectedNode = node;

            this.projectTree.EndUpdate();

            isDirty = true;
        }

        private void FolderMoveUpMenuItem_Click(object sender, EventArgs e)
        {
            MoveUpMenuItem_Click(sender, e);
        }

        private void MoveDownMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = this.projectTree.SelectedNode;

            if (node == null) return;

            TreeNode parent = node.Parent;
            TreeNode nextNode = node.NextNode;

            if (nextNode == null) return;

            this.projectTree.BeginUpdate();

            int index = node.Index;
            int pIndex = node.NextNode.Index;

            parent.Nodes.Remove(nextNode);

            parent.Nodes.Insert(index, nextNode);

            this.projectTree.SelectedNode = node;

            this.projectTree.EndUpdate();

            isDirty = true;
        }

        private void FolderMoveDownMenuItem_Click(object sender, EventArgs e)
        {
            MoveDownMenuItem_Click(sender, e);
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            MoveUpMenuItem_Click(sender, e);
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            MoveDownMenuItem_Click(sender, e);
        }

        public void PromptForSave()
        {
            try
            {
                if (isDirty)
                {
                    DialogResult result = MessageBox.Show("Do you want to save the project", "Your project has unsaved changes",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        if (this.projectName != null)
                        {
                            ButtonSave_Click(null, new EventArgs());
                        }
                        else
                        {
                            ButtonSaveAs_Click(null, new EventArgs());
                        }
                    }

                    isDirty = false;
                }
            }
            catch (Exception ex)
            {
                this.MainWindow.ShowError(ex);
            }
        }
    }

    #region ProjectNodeData

    internal class ProjectNodeData
    {
        public Template Template;
        public Hashtable Input;
        public ISettings Settings;
    }


    #endregion
}
