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

namespace EntitySpaces.AddIn.ES2012
{
    partial class MainWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerTabControl = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.ucProjects = new EntitySpaces.AddIn.ucProjects();
            this.tabTemplates = new System.Windows.Forms.TabPage();
            this.ucTemplates = new EntitySpaces.AddIn.ucTemplates();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.ucSettings = new EntitySpaces.AddIn.ucSettings();
            this.tabMetadata = new System.Windows.Forms.TabPage();
            this.ucMetadata = new EntitySpaces.AddIn.ucMetadata();
            this.tabLanguageMappings = new System.Windows.Forms.TabPage();
            this.ucMappings = new EntitySpaces.AddIn.ucMappings();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlTemplateUI = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExecuteTemplateCancel = new System.Windows.Forms.Button();
            this.buttonExecuteTemplateOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.splitContainerTabControl.Panel1.SuspendLayout();
            this.splitContainerTabControl.Panel2.SuspendLayout();
            this.splitContainerTabControl.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabProjects.SuspendLayout();
            this.tabTemplates.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabMetadata.SuspendLayout();
            this.tabLanguageMappings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainerTabControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.Panel2Collapsed = true;
            this.splitContainer.Panel2MinSize = 40;
            this.splitContainer.Size = new System.Drawing.Size(509, 636);
            this.splitContainer.SplitterDistance = 547;
            this.splitContainer.TabIndex = 1;
            // 
            // splitContainerTabControl
            // 
            this.splitContainerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTabControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTabControl.Name = "splitContainerTabControl";
            // 
            // splitContainerTabControl.Panel1
            // 
            this.splitContainerTabControl.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainerTabControl.Panel2
            // 
            this.splitContainerTabControl.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainerTabControl.Panel2Collapsed = true;
            this.splitContainerTabControl.Size = new System.Drawing.Size(509, 636);
            this.splitContainerTabControl.SplitterDistance = 247;
            this.splitContainerTabControl.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.tabProjects);
            this.tabControl.Controls.Add(this.tabTemplates);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabMetadata);
            this.tabControl.Controls.Add(this.tabLanguageMappings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(509, 636);
            this.tabControl.TabIndex = 0;
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.ucProjects);
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(501, 610);
            this.tabProjects.TabIndex = 6;
            this.tabProjects.Text = "Projects";
            this.tabProjects.UseVisualStyleBackColor = true;
            this.tabProjects.Enter += new System.EventHandler(this.TabPage_Enter);
            // 
            // ucProjects
            // 
            this.ucProjects.AllowDrop = true;
            this.ucProjects.BackColor = System.Drawing.SystemColors.Window;
            this.ucProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjects.Location = new System.Drawing.Point(3, 3);
            this.ucProjects.MainWindow = null;
            this.ucProjects.Name = "ucProjects";
            this.ucProjects.Size = new System.Drawing.Size(495, 604);
            this.ucProjects.TabIndex = 0;
            // 
            // tabTemplates
            // 
            this.tabTemplates.Controls.Add(this.ucTemplates);
            this.tabTemplates.Location = new System.Drawing.Point(4, 22);
            this.tabTemplates.Name = "tabTemplates";
            this.tabTemplates.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemplates.Size = new System.Drawing.Size(501, 610);
            this.tabTemplates.TabIndex = 0;
            this.tabTemplates.Text = "Templates";
            this.tabTemplates.UseVisualStyleBackColor = true;
            this.tabTemplates.Enter += new System.EventHandler(this.TabPage_Enter);
            // 
            // ucTemplates
            // 
            this.ucTemplates.BackColor = System.Drawing.SystemColors.Window;
            this.ucTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTemplates.Location = new System.Drawing.Point(3, 3);
            this.ucTemplates.MainWindow = null;
            this.ucTemplates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucTemplates.Name = "ucTemplates";
            this.ucTemplates.Size = new System.Drawing.Size(495, 604);
            this.ucTemplates.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.ucSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(501, 610);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            this.tabSettings.Enter += new System.EventHandler(this.TabPage_Enter);
            // 
            // ucSettings
            // 
            this.ucSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSettings.Location = new System.Drawing.Point(3, 3);
            this.ucSettings.MainWindow = null;
            this.ucSettings.Margin = new System.Windows.Forms.Padding(4);
            this.ucSettings.Name = "ucSettings";
            this.ucSettings.Padding = new System.Windows.Forms.Padding(3);
            this.ucSettings.Settings = null;
            this.ucSettings.Size = new System.Drawing.Size(495, 604);
            this.ucSettings.TabIndex = 0;
            // 
            // tabMetadata
            // 
            this.tabMetadata.BackColor = System.Drawing.Color.Transparent;
            this.tabMetadata.Controls.Add(this.ucMetadata);
            this.tabMetadata.Location = new System.Drawing.Point(4, 22);
            this.tabMetadata.Name = "tabMetadata";
            this.tabMetadata.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetadata.Size = new System.Drawing.Size(501, 610);
            this.tabMetadata.TabIndex = 1;
            this.tabMetadata.Text = "Metadata";
            this.tabMetadata.UseVisualStyleBackColor = true;
            this.tabMetadata.Enter += new System.EventHandler(this.TabPage_Enter);
            // 
            // ucMetadata
            // 
            this.ucMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMetadata.Location = new System.Drawing.Point(3, 3);
            this.ucMetadata.MainWindow = null;
            this.ucMetadata.Margin = new System.Windows.Forms.Padding(4);
            this.ucMetadata.Name = "ucMetadata";
            this.ucMetadata.Size = new System.Drawing.Size(495, 604);
            this.ucMetadata.TabIndex = 0;
            // 
            // tabLanguageMappings
            // 
            this.tabLanguageMappings.Controls.Add(this.ucMappings);
            this.tabLanguageMappings.Location = new System.Drawing.Point(4, 22);
            this.tabLanguageMappings.Name = "tabLanguageMappings";
            this.tabLanguageMappings.Padding = new System.Windows.Forms.Padding(3);
            this.tabLanguageMappings.Size = new System.Drawing.Size(501, 610);
            this.tabLanguageMappings.TabIndex = 4;
            this.tabLanguageMappings.Text = "Mappings";
            this.tabLanguageMappings.UseVisualStyleBackColor = true;
            this.tabLanguageMappings.Enter += new System.EventHandler(this.TabPage_Enter);
            // 
            // ucMappings
            // 
            this.ucMappings.BackColor = System.Drawing.SystemColors.Window;
            this.ucMappings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMappings.Location = new System.Drawing.Point(3, 3);
            this.ucMappings.MainWindow = null;
            this.ucMappings.Margin = new System.Windows.Forms.Padding(2);
            this.ucMappings.Name = "ucMappings";
            this.ucMappings.Size = new System.Drawing.Size(495, 604);
            this.ucMappings.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tabControlTemplateUI, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(96, 100);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tabControlTemplateUI
            // 
            this.tabControlTemplateUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTemplateUI.Location = new System.Drawing.Point(3, 3);
            this.tabControlTemplateUI.Name = "tabControlTemplateUI";
            this.tabControlTemplateUI.SelectedIndex = 0;
            this.tabControlTemplateUI.Size = new System.Drawing.Size(90, 54);
            this.tabControlTemplateUI.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExecuteTemplateCancel);
            this.panel1.Controls.Add(this.buttonExecuteTemplateOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 34);
            this.panel1.TabIndex = 1;
            // 
            // buttonExecuteTemplateCancel
            // 
            this.buttonExecuteTemplateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecuteTemplateCancel.Location = new System.Drawing.Point(-69, 8);
            this.buttonExecuteTemplateCancel.Name = "buttonExecuteTemplateCancel";
            this.buttonExecuteTemplateCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuteTemplateCancel.TabIndex = 3;
            this.buttonExecuteTemplateCancel.Text = "&Cancel";
            this.buttonExecuteTemplateCancel.UseVisualStyleBackColor = true;
            this.buttonExecuteTemplateCancel.Click += new System.EventHandler(this.buttonExecuteTemplateCancel_Click);
            // 
            // buttonExecuteTemplateOk
            // 
            this.buttonExecuteTemplateOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecuteTemplateOk.Location = new System.Drawing.Point(12, 8);
            this.buttonExecuteTemplateOk.Name = "buttonExecuteTemplateOk";
            this.buttonExecuteTemplateOk.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuteTemplateOk.TabIndex = 2;
            this.buttonExecuteTemplateOk.Text = "&Ok";
            this.buttonExecuteTemplateOk.UseVisualStyleBackColor = true;
            this.buttonExecuteTemplateOk.Click += new System.EventHandler(this.buttonExecuteTemplateOk_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxError, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxError
            // 
            this.textBoxError.BackColor = System.Drawing.Color.Black;
            this.textBoxError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxError.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxError.Location = new System.Drawing.Point(73, 3);
            this.textBoxError.Multiline = true;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxError.Size = new System.Drawing.Size(74, 40);
            this.textBoxError.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxError, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(64, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.ErrorImage = null;
            this.pictureBoxError.Image = global::EntitySpaces.AddIn.Resource.error;
            this.pictureBoxError.InitialImage = null;
            this.pictureBoxError.Location = new System.Drawing.Point(3, -3);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(51, 48);
            this.pictureBoxError.TabIndex = 0;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Click += new System.EventHandler(this.pictureBoxError_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "error.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "MainWindow";
            this.Size = new System.Drawing.Size(509, 636);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.splitContainerTabControl.Panel1.ResumeLayout(false);
            this.splitContainerTabControl.Panel2.ResumeLayout(false);
            this.splitContainerTabControl.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            this.tabTemplates.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabMetadata.ResumeLayout(false);
            this.tabLanguageMappings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTemplates;
        private System.Windows.Forms.TabPage tabMetadata;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabLanguageMappings;
        private ucMetadata ucMetadata;
        private ucMappings ucMappings;
        private ucTemplates ucTemplates;
        private ucSettings ucSettings;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainerTabControl;
        public System.Windows.Forms.TabControl tabControlTemplateUI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExecuteTemplateCancel;
        private System.Windows.Forms.Button buttonExecuteTemplateOk;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabProjects;
        private ucProjects ucProjects;
        private System.Windows.Forms.PictureBox pictureBoxError;
    }
}
