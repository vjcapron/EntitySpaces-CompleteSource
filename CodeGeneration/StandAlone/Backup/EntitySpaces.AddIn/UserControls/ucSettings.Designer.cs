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

namespace EntitySpaces.AddIn
{
    partial class ucSettings
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label labelTemplatePath;
            System.Windows.Forms.Label labelOutputPath;
            System.Windows.Forms.Label labelAssemblyPath;
            System.Windows.Forms.Label labelCompilerAssemblyPath;
            System.Windows.Forms.Label labelLanguageMap;
            System.Windows.Forms.Label labelUserMetadata;
            System.Windows.Forms.Label labelAbstractPrefix;
            System.Windows.Forms.Label labelEntitySuffix;
            System.Windows.Forms.Label labelCollectionSuffix;
            System.Windows.Forms.Label labelQuerySuffix;
            System.Windows.Forms.Label labelMetadataSuffix;
            System.Windows.Forms.Label labelProxyStubSuffix;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            System.Windows.Forms.Label labelProcPrefix;
            System.Windows.Forms.Label labelProcInsert;
            System.Windows.Forms.Label labelProcUpdate;
            System.Windows.Forms.Label labelProcDelete;
            System.Windows.Forms.Label labelProcLoadAll;
            System.Windows.Forms.Label labelProcLoadByPK;
            System.Windows.Forms.Label labelProcSuffix;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSettings));
            this.textBoxProcPrefix = new System.Windows.Forms.TextBox();
            this.textBoxProcInsert = new System.Windows.Forms.TextBox();
            this.textBoxProcUpdate = new System.Windows.Forms.TextBox();
            this.textBoxProcDelete = new System.Windows.Forms.TextBox();
            this.textBoxProcLoadAll = new System.Windows.Forms.TextBox();
            this.textBoxProcLoadByPK = new System.Windows.Forms.TextBox();
            this.textBoxProcSuffix = new System.Windows.Forms.TextBox();
            this.checkBoxProcVerbFirst = new System.Windows.Forms.CheckBox();
            this.labelProcSample = new System.Windows.Forms.Label();
            this.toolStripSettings = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSetDefault = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReloadDefault = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonButtonMRU = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuMRU = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxConnectionHelp = new System.Windows.Forms.TextBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.buttonOleDB = new System.Windows.Forms.Button();
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageLocations = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelLocations = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTemplatePath = new System.Windows.Forms.Button();
            this.buttonOutputPath = new System.Windows.Forms.Button();
            this.textBoxTemplatePath = new System.Windows.Forms.TextBox();
            this.textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.textBoxUIAssemblyPath = new System.Windows.Forms.TextBox();
            this.buttonUIAssemblyPath = new System.Windows.Forms.Button();
            this.textBoxCompilerAssemblyPath = new System.Windows.Forms.TextBox();
            this.buttonCompilerAssemblyPath = new System.Windows.Forms.Button();
            this.textBoxLanguageMap = new System.Windows.Forms.TextBox();
            this.textBoxUserMetadata = new System.Windows.Forms.TextBox();
            this.buttonLanguageMap = new System.Windows.Forms.Button();
            this.buttonUserMetadata = new System.Windows.Forms.Button();
            this.tabPageNaming = new System.Windows.Forms.TabPage();
            this.tabControlNaming = new System.Windows.Forms.TabControl();
            this.tabPageClass = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxProxyStubSuffix = new System.Windows.Forms.TextBox();
            this.textBoxMetadataSuffix = new System.Windows.Forms.TextBox();
            this.textBoxQuerySuffix = new System.Windows.Forms.TextBox();
            this.textBoxCollectionSuffix = new System.Windows.Forms.TextBox();
            this.textBoxEntitySuffix = new System.Windows.Forms.TextBox();
            this.textBoxAbstractPrefix = new System.Windows.Forms.TextBox();
            this.checkboxPrefixWithSchema = new System.Windows.Forms.CheckBox();
            this.tabPageSP = new System.Windows.Forms.TabPage();
            this.tabPageHierarchical = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHierPrefix = new System.Windows.Forms.Label();
            this.labelHierSuffix = new System.Windows.Forms.Label();
            this.labelHierSeparator = new System.Windows.Forms.Label();
            this.labelHierEntity = new System.Windows.Forms.Label();
            this.labelHierCollection = new System.Windows.Forms.Label();
            this.labelHierTable1 = new System.Windows.Forms.Label();
            this.labelHierTable2 = new System.Windows.Forms.Label();
            this.labelHierColumn1 = new System.Windows.Forms.Label();
            this.labelHierColumn2 = new System.Windows.Forms.Label();
            this.textBoxOnePrefix = new System.Windows.Forms.TextBox();
            this.textBoxOneSuffix = new System.Windows.Forms.TextBox();
            this.textBoxOneSeparator = new System.Windows.Forms.TextBox();
            this.textBoxManyPrefix = new System.Windows.Forms.TextBox();
            this.textBoxManySuffix = new System.Windows.Forms.TextBox();
            this.textBoxManySeparator = new System.Windows.Forms.TextBox();
            this.checkBoxSelfOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxSwapNames = new System.Windows.Forms.CheckBox();
            this.checkBoxUseAssociativeName = new System.Windows.Forms.CheckBox();
            this.checkBoxUseUpToPrefix = new System.Windows.Forms.CheckBox();
            this.labelSample = new System.Windows.Forms.Label();
            this.labelHierSample = new System.Windows.Forms.Label();
            this.labelHierTypes = new System.Windows.Forms.Label();
            this.tabPageMisc = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxUseRawNames = new System.Windows.Forms.CheckBox();
            this.checkBoxPreserveUnderscores = new System.Windows.Forms.CheckBox();
            this.tabPageFields = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateAddedServerSideText = new System.Windows.Forms.TextBox();
            this.txtDateAddedColumnName = new System.Windows.Forms.TextBox();
            this.chkDateAddedEnabled = new System.Windows.Forms.CheckBox();
            this.chkDateAddedServerSideEnabled = new System.Windows.Forms.CheckBox();
            this.chkDateAddedClientSideEnabled = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoDateAddedClientSideUtcNow = new System.Windows.Forms.RadioButton();
            this.rdoDateAddedClientSideNow = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateModifiedServerSideText = new System.Windows.Forms.TextBox();
            this.txtDateModifiedColumnName = new System.Windows.Forms.TextBox();
            this.chkDateModifiedEnabled = new System.Windows.Forms.CheckBox();
            this.chkDateModifiedServerSideEnabled = new System.Windows.Forms.CheckBox();
            this.chkDateModifiedClientSideEnabled = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoDateModifiedClientSideUtcNow = new System.Windows.Forms.RadioButton();
            this.rdoDateModifiedClientSideNow = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.txtModifiedByColumnName = new System.Windows.Forms.TextBox();
            this.txtModifiedByServerSideText = new System.Windows.Forms.TextBox();
            this.chkModifiedByEnabled = new System.Windows.Forms.CheckBox();
            this.chkModifiedByServerSide = new System.Windows.Forms.CheckBox();
            this.chkModifiedByEventHandler = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAddedByColumnName = new System.Windows.Forms.TextBox();
            this.txtAddedByServerSideText = new System.Windows.Forms.TextBox();
            this.chkAddedByEnabled = new System.Windows.Forms.CheckBox();
            this.chkAddedByServerSide = new System.Windows.Forms.CheckBox();
            this.chkAddedByEventHandler = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.txtConcurrencyColumnName = new System.Windows.Forms.TextBox();
            this.chkConcurrencyColumn = new System.Windows.Forms.CheckBox();
            this.lblSelectedDriver = new System.Windows.Forms.Label();
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTemplateDoubleClick = new System.Windows.Forms.GroupBox();
            this.radioButtonExecuteWithLastSettings = new System.Windows.Forms.RadioButton();
            this.radioButtonExecute = new System.Windows.Forms.RadioButton();
            this.radioButtonEditTemplate = new System.Windows.Forms.RadioButton();
            this.checkBoxUseNullableTypes = new System.Windows.Forms.CheckBox();
            this.checkBoxNoDatesInHeader = new System.Windows.Forms.CheckBox();
            this.tooltipPrefix = new System.Windows.Forms.ToolTip(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelTemplatePath = new System.Windows.Forms.Label();
            labelOutputPath = new System.Windows.Forms.Label();
            labelAssemblyPath = new System.Windows.Forms.Label();
            labelCompilerAssemblyPath = new System.Windows.Forms.Label();
            labelLanguageMap = new System.Windows.Forms.Label();
            labelUserMetadata = new System.Windows.Forms.Label();
            labelAbstractPrefix = new System.Windows.Forms.Label();
            labelEntitySuffix = new System.Windows.Forms.Label();
            labelCollectionSuffix = new System.Windows.Forms.Label();
            labelQuerySuffix = new System.Windows.Forms.Label();
            labelMetadataSuffix = new System.Windows.Forms.Label();
            labelProxyStubSuffix = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            labelProcPrefix = new System.Windows.Forms.Label();
            labelProcInsert = new System.Windows.Forms.Label();
            labelProcUpdate = new System.Windows.Forms.Label();
            labelProcDelete = new System.Windows.Forms.Label();
            labelProcLoadAll = new System.Windows.Forms.Label();
            labelProcLoadByPK = new System.Windows.Forms.Label();
            labelProcSuffix = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            tableLayoutPanel3.SuspendLayout();
            this.toolStripSettings.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPageLocations.SuspendLayout();
            this.tableLayoutPanelLocations.SuspendLayout();
            this.tabPageNaming.SuspendLayout();
            this.tabControlNaming.SuspendLayout();
            this.tabPageClass.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageSP.SuspendLayout();
            this.tabPageHierarchical.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPageMisc.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageFields.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            this.tabPageOther.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxTemplateDoubleClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 0;
            label1.Text = "Driver";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 13);
            label2.TabIndex = 3;
            label2.Text = "Connection String";
            // 
            // labelTemplatePath
            // 
            labelTemplatePath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelTemplatePath.AutoSize = true;
            labelTemplatePath.Location = new System.Drawing.Point(44, 8);
            labelTemplatePath.Name = "labelTemplatePath";
            labelTemplatePath.Size = new System.Drawing.Size(79, 13);
            labelTemplatePath.TabIndex = 0;
            labelTemplatePath.Text = "Template Path:";
            // 
            // labelOutputPath
            // 
            labelOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelOutputPath.AutoSize = true;
            labelOutputPath.Location = new System.Drawing.Point(56, 37);
            labelOutputPath.Name = "labelOutputPath";
            labelOutputPath.Size = new System.Drawing.Size(67, 13);
            labelOutputPath.TabIndex = 1;
            labelOutputPath.Text = "Output Path:";
            // 
            // labelAssemblyPath
            // 
            labelAssemblyPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelAssemblyPath.AutoSize = true;
            labelAssemblyPath.Location = new System.Drawing.Point(30, 66);
            labelAssemblyPath.Name = "labelAssemblyPath";
            labelAssemblyPath.Size = new System.Drawing.Size(93, 13);
            labelAssemblyPath.TabIndex = 2;
            labelAssemblyPath.Text = "UI Assembly Path:";
            // 
            // labelCompilerAssemblyPath
            // 
            labelCompilerAssemblyPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCompilerAssemblyPath.AutoSize = true;
            labelCompilerAssemblyPath.Location = new System.Drawing.Point(4, 95);
            labelCompilerAssemblyPath.Name = "labelCompilerAssemblyPath";
            labelCompilerAssemblyPath.Size = new System.Drawing.Size(119, 13);
            labelCompilerAssemblyPath.TabIndex = 3;
            labelCompilerAssemblyPath.Text = "Compiler Assembly Path";
            // 
            // labelLanguageMap
            // 
            labelLanguageMap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelLanguageMap.AutoSize = true;
            labelLanguageMap.Location = new System.Drawing.Point(21, 124);
            labelLanguageMap.Name = "labelLanguageMap";
            labelLanguageMap.Size = new System.Drawing.Size(102, 13);
            labelLanguageMap.TabIndex = 4;
            labelLanguageMap.Text = "Language Mapping:";
            // 
            // labelUserMetadata
            // 
            labelUserMetadata.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelUserMetadata.AutoSize = true;
            labelUserMetadata.Location = new System.Drawing.Point(46, 153);
            labelUserMetadata.Name = "labelUserMetadata";
            labelUserMetadata.Size = new System.Drawing.Size(77, 13);
            labelUserMetadata.TabIndex = 5;
            labelUserMetadata.Text = "User Metadata";
            // 
            // labelAbstractPrefix
            // 
            labelAbstractPrefix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelAbstractPrefix.AutoSize = true;
            labelAbstractPrefix.Location = new System.Drawing.Point(39, 6);
            labelAbstractPrefix.Name = "labelAbstractPrefix";
            labelAbstractPrefix.Size = new System.Drawing.Size(78, 13);
            labelAbstractPrefix.TabIndex = 0;
            labelAbstractPrefix.Text = "Abstract Prefix:";
            // 
            // labelEntitySuffix
            // 
            labelEntitySuffix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelEntitySuffix.AutoSize = true;
            labelEntitySuffix.Location = new System.Drawing.Point(52, 32);
            labelEntitySuffix.Name = "labelEntitySuffix";
            labelEntitySuffix.Size = new System.Drawing.Size(65, 13);
            labelEntitySuffix.TabIndex = 1;
            labelEntitySuffix.Text = "Entity Suffix:";
            // 
            // labelCollectionSuffix
            // 
            labelCollectionSuffix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCollectionSuffix.AutoSize = true;
            labelCollectionSuffix.Location = new System.Drawing.Point(32, 58);
            labelCollectionSuffix.Name = "labelCollectionSuffix";
            labelCollectionSuffix.Size = new System.Drawing.Size(85, 13);
            labelCollectionSuffix.TabIndex = 2;
            labelCollectionSuffix.Text = "Collection Suffix:";
            // 
            // labelQuerySuffix
            // 
            labelQuerySuffix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelQuerySuffix.AutoSize = true;
            labelQuerySuffix.Location = new System.Drawing.Point(50, 84);
            labelQuerySuffix.Name = "labelQuerySuffix";
            labelQuerySuffix.Size = new System.Drawing.Size(67, 13);
            labelQuerySuffix.TabIndex = 3;
            labelQuerySuffix.Text = "Query Suffix:";
            // 
            // labelMetadataSuffix
            // 
            labelMetadataSuffix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelMetadataSuffix.AutoSize = true;
            labelMetadataSuffix.Location = new System.Drawing.Point(33, 110);
            labelMetadataSuffix.Name = "labelMetadataSuffix";
            labelMetadataSuffix.Size = new System.Drawing.Size(84, 13);
            labelMetadataSuffix.TabIndex = 4;
            labelMetadataSuffix.Text = "Metadata Suffix:";
            // 
            // labelProxyStubSuffix
            // 
            labelProxyStubSuffix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProxyStubSuffix.AutoSize = true;
            labelProxyStubSuffix.Location = new System.Drawing.Point(30, 136);
            labelProxyStubSuffix.Name = "labelProxyStubSuffix";
            labelProxyStubSuffix.Size = new System.Drawing.Size(87, 13);
            labelProxyStubSuffix.TabIndex = 5;
            labelProxyStubSuffix.Text = "ProxyStub Suffix:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(labelProcPrefix, 0, 0);
            tableLayoutPanel3.Controls.Add(labelProcInsert, 0, 1);
            tableLayoutPanel3.Controls.Add(labelProcUpdate, 0, 2);
            tableLayoutPanel3.Controls.Add(labelProcDelete, 0, 3);
            tableLayoutPanel3.Controls.Add(labelProcLoadAll, 0, 4);
            tableLayoutPanel3.Controls.Add(labelProcLoadByPK, 0, 5);
            tableLayoutPanel3.Controls.Add(labelProcSuffix, 0, 6);
            tableLayoutPanel3.Controls.Add(this.textBoxProcPrefix, 1, 0);
            tableLayoutPanel3.Controls.Add(this.textBoxProcInsert, 1, 1);
            tableLayoutPanel3.Controls.Add(this.textBoxProcUpdate, 1, 2);
            tableLayoutPanel3.Controls.Add(this.textBoxProcDelete, 1, 3);
            tableLayoutPanel3.Controls.Add(this.textBoxProcLoadAll, 1, 4);
            tableLayoutPanel3.Controls.Add(this.textBoxProcLoadByPK, 1, 5);
            tableLayoutPanel3.Controls.Add(this.textBoxProcSuffix, 1, 6);
            tableLayoutPanel3.Controls.Add(this.checkBoxProcVerbFirst, 1, 7);
            tableLayoutPanel3.Controls.Add(label3, 0, 10);
            tableLayoutPanel3.Controls.Add(this.labelProcSample, 1, 10);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 11;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(423, 435);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // labelProcPrefix
            // 
            labelProcPrefix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProcPrefix.AutoSize = true;
            labelProcPrefix.Location = new System.Drawing.Point(69, 6);
            labelProcPrefix.Name = "labelProcPrefix";
            labelProcPrefix.Size = new System.Drawing.Size(36, 13);
            labelProcPrefix.TabIndex = 0;
            labelProcPrefix.Text = "Prefix:";
            // 
            // labelProcInsert
            // 
            labelProcInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProcInsert.AutoSize = true;
            labelProcInsert.Location = new System.Drawing.Point(39, 32);
            labelProcInsert.Name = "labelProcInsert";
            labelProcInsert.Size = new System.Drawing.Size(66, 13);
            labelProcInsert.TabIndex = 1;
            labelProcInsert.Text = "Insert (verb):";
            // 
            // labelProcUpdate
            // 
            labelProcUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProcUpdate.AutoSize = true;
            labelProcUpdate.Location = new System.Drawing.Point(30, 58);
            labelProcUpdate.Name = "labelProcUpdate";
            labelProcUpdate.Size = new System.Drawing.Size(75, 13);
            labelProcUpdate.TabIndex = 2;
            labelProcUpdate.Text = "Update (verb):";
            // 
            // labelProcDelete
            // 
            labelProcDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProcDelete.AutoSize = true;
            labelProcDelete.Location = new System.Drawing.Point(34, 84);
            labelProcDelete.Name = "labelProcDelete";
            labelProcDelete.Size = new System.Drawing.Size(71, 13);
            labelProcDelete.TabIndex = 3;
            labelProcDelete.Text = "Delete (verb):";
            // 
            // labelProcLoadAll
            // 
            labelProcLoadAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProcLoadAll.AutoSize = true;
            labelProcLoadAll.Location = new System.Drawing.Point(27, 110);
            labelProcLoadAll.Name = "labelProcLoadAll";
            labelProcLoadAll.Size = new System.Drawing.Size(78, 13);
            labelProcLoadAll.TabIndex = 4;
            labelProcLoadAll.Text = "Load All (verb):";
            // 
            // labelProcLoadByPK
            // 
            labelProcLoadByPK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProcLoadByPK.AutoSize = true;
            labelProcLoadByPK.Location = new System.Drawing.Point(10, 136);
            labelProcLoadByPK.Name = "labelProcLoadByPK";
            labelProcLoadByPK.Size = new System.Drawing.Size(95, 13);
            labelProcLoadByPK.TabIndex = 5;
            labelProcLoadByPK.Text = "Load by PK (verb):";
            // 
            // labelProcSuffix
            // 
            labelProcSuffix.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelProcSuffix.AutoSize = true;
            labelProcSuffix.Location = new System.Drawing.Point(69, 162);
            labelProcSuffix.Name = "labelProcSuffix";
            labelProcSuffix.Size = new System.Drawing.Size(36, 13);
            labelProcSuffix.TabIndex = 6;
            labelProcSuffix.Text = "Suffix:";
            // 
            // textBoxProcPrefix
            // 
            this.textBoxProcPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcPrefix.Location = new System.Drawing.Point(111, 3);
            this.textBoxProcPrefix.Name = "textBoxProcPrefix";
            this.textBoxProcPrefix.Size = new System.Drawing.Size(277, 20);
            this.textBoxProcPrefix.TabIndex = 7;
            this.textBoxProcPrefix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProcTextBox_KeyUp);
            // 
            // textBoxProcInsert
            // 
            this.textBoxProcInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcInsert.Location = new System.Drawing.Point(111, 29);
            this.textBoxProcInsert.Name = "textBoxProcInsert";
            this.textBoxProcInsert.Size = new System.Drawing.Size(277, 20);
            this.textBoxProcInsert.TabIndex = 8;
            this.textBoxProcInsert.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProcTextBox_KeyUp);
            // 
            // textBoxProcUpdate
            // 
            this.textBoxProcUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcUpdate.Location = new System.Drawing.Point(111, 55);
            this.textBoxProcUpdate.Name = "textBoxProcUpdate";
            this.textBoxProcUpdate.Size = new System.Drawing.Size(277, 20);
            this.textBoxProcUpdate.TabIndex = 9;
            this.textBoxProcUpdate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProcTextBox_KeyUp);
            // 
            // textBoxProcDelete
            // 
            this.textBoxProcDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcDelete.Location = new System.Drawing.Point(111, 81);
            this.textBoxProcDelete.Name = "textBoxProcDelete";
            this.textBoxProcDelete.Size = new System.Drawing.Size(277, 20);
            this.textBoxProcDelete.TabIndex = 10;
            this.textBoxProcDelete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProcTextBox_KeyUp);
            // 
            // textBoxProcLoadAll
            // 
            this.textBoxProcLoadAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcLoadAll.Location = new System.Drawing.Point(111, 107);
            this.textBoxProcLoadAll.Name = "textBoxProcLoadAll";
            this.textBoxProcLoadAll.Size = new System.Drawing.Size(277, 20);
            this.textBoxProcLoadAll.TabIndex = 11;
            this.textBoxProcLoadAll.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProcTextBox_KeyUp);
            // 
            // textBoxProcLoadByPK
            // 
            this.textBoxProcLoadByPK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcLoadByPK.Location = new System.Drawing.Point(111, 133);
            this.textBoxProcLoadByPK.Name = "textBoxProcLoadByPK";
            this.textBoxProcLoadByPK.Size = new System.Drawing.Size(277, 20);
            this.textBoxProcLoadByPK.TabIndex = 12;
            this.textBoxProcLoadByPK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProcTextBox_KeyUp);
            // 
            // textBoxProcSuffix
            // 
            this.textBoxProcSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcSuffix.Location = new System.Drawing.Point(111, 159);
            this.textBoxProcSuffix.Name = "textBoxProcSuffix";
            this.textBoxProcSuffix.Size = new System.Drawing.Size(277, 20);
            this.textBoxProcSuffix.TabIndex = 13;
            this.textBoxProcSuffix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProcTextBox_KeyUp);
            // 
            // checkBoxProcVerbFirst
            // 
            this.checkBoxProcVerbFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxProcVerbFirst.AutoSize = true;
            this.checkBoxProcVerbFirst.Location = new System.Drawing.Point(111, 185);
            this.checkBoxProcVerbFirst.Name = "checkBoxProcVerbFirst";
            this.checkBoxProcVerbFirst.Size = new System.Drawing.Size(277, 17);
            this.checkBoxProcVerbFirst.TabIndex = 14;
            this.checkBoxProcVerbFirst.Text = "Put verb before the table name.";
            this.checkBoxProcVerbFirst.UseVisualStyleBackColor = true;
            this.checkBoxProcVerbFirst.CheckedChanged += new System.EventHandler(this.checkBoxProcVerbFirst_CheckedChanged);
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 225);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 15;
            label3.Text = "Sample:";
            // 
            // labelProcSample
            // 
            this.labelProcSample.AutoSize = true;
            this.labelProcSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcSample.Location = new System.Drawing.Point(111, 225);
            this.labelProcSample.Name = "labelProcSample";
            this.labelProcSample.Size = new System.Drawing.Size(277, 210);
            this.labelProcSample.TabIndex = 16;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(17, 162);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 13);
            label10.TabIndex = 5;
            label10.Text = "Prefix with Schema:";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(39, 13);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(38, 13);
            label11.TabIndex = 3;
            label11.Text = "Driver:";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripSettings.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSetDefault,
            this.toolStripButtonReloadDefault,
            this.toolStripSeparator1,
            this.toolStripButtonButtonMRU,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonHelp});
            this.toolStripSettings.Location = new System.Drawing.Point(0, 0);
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(451, 25);
            this.toolStripSettings.TabIndex = 0;
            this.toolStripSettings.TabStop = true;
            this.toolStripSettings.Text = "toolStrip1";
            // 
            // toolStripButtonSetDefault
            // 
            this.toolStripButtonSetDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetDefault.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetDefault.Image")));
            this.toolStripButtonSetDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetDefault.Name = "toolStripButtonSetDefault";
            this.toolStripButtonSetDefault.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSetDefault.Text = "Save &Default Settings";
            this.toolStripButtonSetDefault.Click += new System.EventHandler(this.toolStripButtonSetDefault_Click);
            // 
            // toolStripButtonReloadDefault
            // 
            this.toolStripButtonReloadDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReloadDefault.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReloadDefault.Image")));
            this.toolStripButtonReloadDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReloadDefault.Name = "toolStripButtonReloadDefault";
            this.toolStripButtonReloadDefault.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReloadDefault.Text = "&Reload Default Settings";
            this.toolStripButtonReloadDefault.Click += new System.EventHandler(this.toolStripButtonReloadDefault_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonButtonMRU
            // 
            this.toolStripButtonButtonMRU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonButtonMRU.DropDown = this.menuMRU;
            this.toolStripButtonButtonMRU.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonButtonMRU.Image")));
            this.toolStripButtonButtonMRU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonButtonMRU.Name = "toolStripButtonButtonMRU";
            this.toolStripButtonButtonMRU.Size = new System.Drawing.Size(29, 22);
            this.toolStripButtonButtonMRU.Text = "Most Recently Used Settings Files";
            // 
            // menuMRU
            // 
            this.menuMRU.Name = "menuMRU";
            this.menuMRU.OwnerItem = this.toolStripButtonButtonMRU;
            this.menuMRU.Size = new System.Drawing.Size(61, 4);
            this.menuMRU.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMRU_ItemClicked);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "&Open Named Settings File";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "&Save as a Named Settings File";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHelp.Image")));
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHelp.Text = "He&lp";
            this.toolStripButtonHelp.Visible = false;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageConnection);
            this.tabControlSettings.Controls.Add(this.tabPageLocations);
            this.tabControlSettings.Controls.Add(this.tabPageNaming);
            this.tabControlSettings.Controls.Add(this.tabPageFields);
            this.tabControlSettings.Controls.Add(this.tabPageOther);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.HotTrack = true;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 25);
            this.tabControlSettings.Multiline = true;
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(451, 499);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.AutoScroll = true;
            this.tabPageConnection.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageConnection.Controls.Add(this.tableLayoutPanel5);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(443, 473);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel5.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxConnectionHelp, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.buttonTestConnection, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.textBoxConnectionString, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.buttonOleDB, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxDriver, 0, 1);
            this.tableLayoutPanel5.Controls.Add(label2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(437, 467);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // textBoxConnectionHelp
            // 
            this.textBoxConnectionHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConnectionHelp.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConnectionHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel5.SetColumnSpan(this.textBoxConnectionHelp, 2);
            this.textBoxConnectionHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionHelp.ForeColor = System.Drawing.Color.Blue;
            this.textBoxConnectionHelp.Location = new System.Drawing.Point(3, 329);
            this.textBoxConnectionHelp.Multiline = true;
            this.textBoxConnectionHelp.Name = "textBoxConnectionHelp";
            this.textBoxConnectionHelp.ReadOnly = true;
            this.textBoxConnectionHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConnectionHelp.Size = new System.Drawing.Size(431, 105);
            this.textBoxConnectionHelp.TabIndex = 5;
            this.textBoxConnectionHelp.TabStop = false;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestConnection.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTestConnection.Location = new System.Drawing.Point(340, 441);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(94, 23);
            this.buttonTestConnection.TabIndex = 7;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.textBoxConnectionString, 2);
            this.textBoxConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionString.Location = new System.Drawing.Point(3, 70);
            this.textBoxConnectionString.Multiline = true;
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConnectionString.Size = new System.Drawing.Size(431, 253);
            this.textBoxConnectionString.TabIndex = 4;
            // 
            // buttonOleDB
            // 
            this.buttonOleDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOleDB.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOleDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOleDB.Location = new System.Drawing.Point(293, 23);
            this.buttonOleDB.Name = "buttonOleDB";
            this.buttonOleDB.Size = new System.Drawing.Size(141, 21);
            this.buttonOleDB.TabIndex = 2;
            this.buttonOleDB.Text = "Configure Connection";
            this.buttonOleDB.UseVisualStyleBackColor = true;
            this.buttonOleDB.Click += new System.EventHandler(this.buttonOleDB_Click);
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Location = new System.Drawing.Point(3, 23);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(284, 21);
            this.comboBoxDriver.TabIndex = 1;
            this.comboBoxDriver.SelectedIndexChanged += new System.EventHandler(this.comboBoxDriver_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "2012.1.0930.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageLocations
            // 
            this.tabPageLocations.Controls.Add(this.tableLayoutPanelLocations);
            this.tabPageLocations.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocations.Name = "tabPageLocations";
            this.tabPageLocations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocations.Size = new System.Drawing.Size(443, 473);
            this.tabPageLocations.TabIndex = 1;
            this.tabPageLocations.Text = "File Locations";
            this.tabPageLocations.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelLocations
            // 
            this.tableLayoutPanelLocations.AutoScroll = true;
            this.tableLayoutPanelLocations.ColumnCount = 3;
            this.tableLayoutPanelLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanelLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanelLocations.Controls.Add(labelTemplatePath, 0, 0);
            this.tableLayoutPanelLocations.Controls.Add(labelOutputPath, 0, 1);
            this.tableLayoutPanelLocations.Controls.Add(this.buttonTemplatePath, 2, 0);
            this.tableLayoutPanelLocations.Controls.Add(this.buttonOutputPath, 2, 1);
            this.tableLayoutPanelLocations.Controls.Add(this.textBoxTemplatePath, 1, 0);
            this.tableLayoutPanelLocations.Controls.Add(this.textBoxOutputPath, 1, 1);
            this.tableLayoutPanelLocations.Controls.Add(labelAssemblyPath, 0, 2);
            this.tableLayoutPanelLocations.Controls.Add(this.textBoxUIAssemblyPath, 1, 2);
            this.tableLayoutPanelLocations.Controls.Add(this.buttonUIAssemblyPath, 2, 2);
            this.tableLayoutPanelLocations.Controls.Add(labelCompilerAssemblyPath, 0, 3);
            this.tableLayoutPanelLocations.Controls.Add(this.textBoxCompilerAssemblyPath, 1, 3);
            this.tableLayoutPanelLocations.Controls.Add(this.buttonCompilerAssemblyPath, 2, 3);
            this.tableLayoutPanelLocations.Controls.Add(labelLanguageMap, 0, 4);
            this.tableLayoutPanelLocations.Controls.Add(labelUserMetadata, 0, 5);
            this.tableLayoutPanelLocations.Controls.Add(this.textBoxLanguageMap, 1, 4);
            this.tableLayoutPanelLocations.Controls.Add(this.textBoxUserMetadata, 1, 5);
            this.tableLayoutPanelLocations.Controls.Add(this.buttonLanguageMap, 2, 4);
            this.tableLayoutPanelLocations.Controls.Add(this.buttonUserMetadata, 2, 5);
            this.tableLayoutPanelLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLocations.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLocations.Name = "tableLayoutPanelLocations";
            this.tableLayoutPanelLocations.RowCount = 7;
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLocations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLocations.Size = new System.Drawing.Size(437, 467);
            this.tableLayoutPanelLocations.TabIndex = 0;
            // 
            // buttonTemplatePath
            // 
            this.buttonTemplatePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonTemplatePath.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTemplatePath.Location = new System.Drawing.Point(356, 3);
            this.buttonTemplatePath.Name = "buttonTemplatePath";
            this.buttonTemplatePath.Size = new System.Drawing.Size(74, 23);
            this.buttonTemplatePath.TabIndex = 7;
            this.buttonTemplatePath.Text = "Browse";
            this.buttonTemplatePath.UseVisualStyleBackColor = true;
            this.buttonTemplatePath.Click += new System.EventHandler(this.buttonTemplatePath_Click);
            // 
            // buttonOutputPath
            // 
            this.buttonOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonOutputPath.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOutputPath.Location = new System.Drawing.Point(356, 32);
            this.buttonOutputPath.Name = "buttonOutputPath";
            this.buttonOutputPath.Size = new System.Drawing.Size(74, 23);
            this.buttonOutputPath.TabIndex = 9;
            this.buttonOutputPath.Text = "Browse";
            this.buttonOutputPath.UseVisualStyleBackColor = true;
            this.buttonOutputPath.Click += new System.EventHandler(this.buttonOutputPath_Click);
            // 
            // textBoxTemplatePath
            // 
            this.textBoxTemplatePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTemplatePath.Location = new System.Drawing.Point(129, 4);
            this.textBoxTemplatePath.Name = "textBoxTemplatePath";
            this.textBoxTemplatePath.Size = new System.Drawing.Size(221, 20);
            this.textBoxTemplatePath.TabIndex = 6;
            // 
            // textBoxOutputPath
            // 
            this.textBoxOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputPath.Location = new System.Drawing.Point(129, 33);
            this.textBoxOutputPath.Name = "textBoxOutputPath";
            this.textBoxOutputPath.Size = new System.Drawing.Size(221, 20);
            this.textBoxOutputPath.TabIndex = 8;
            // 
            // textBoxUIAssemblyPath
            // 
            this.textBoxUIAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUIAssemblyPath.Location = new System.Drawing.Point(129, 62);
            this.textBoxUIAssemblyPath.Name = "textBoxUIAssemblyPath";
            this.textBoxUIAssemblyPath.Size = new System.Drawing.Size(221, 20);
            this.textBoxUIAssemblyPath.TabIndex = 10;
            // 
            // buttonUIAssemblyPath
            // 
            this.buttonUIAssemblyPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUIAssemblyPath.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUIAssemblyPath.Location = new System.Drawing.Point(356, 61);
            this.buttonUIAssemblyPath.Name = "buttonUIAssemblyPath";
            this.buttonUIAssemblyPath.Size = new System.Drawing.Size(74, 23);
            this.buttonUIAssemblyPath.TabIndex = 11;
            this.buttonUIAssemblyPath.Text = "Browse";
            this.buttonUIAssemblyPath.UseVisualStyleBackColor = true;
            this.buttonUIAssemblyPath.Click += new System.EventHandler(this.buttonUIAssemblyPath_Click);
            // 
            // textBoxCompilerAssemblyPath
            // 
            this.textBoxCompilerAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCompilerAssemblyPath.Location = new System.Drawing.Point(129, 91);
            this.textBoxCompilerAssemblyPath.Name = "textBoxCompilerAssemblyPath";
            this.textBoxCompilerAssemblyPath.Size = new System.Drawing.Size(221, 20);
            this.textBoxCompilerAssemblyPath.TabIndex = 12;
            // 
            // buttonCompilerAssemblyPath
            // 
            this.buttonCompilerAssemblyPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCompilerAssemblyPath.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCompilerAssemblyPath.Location = new System.Drawing.Point(356, 90);
            this.buttonCompilerAssemblyPath.Name = "buttonCompilerAssemblyPath";
            this.buttonCompilerAssemblyPath.Size = new System.Drawing.Size(74, 23);
            this.buttonCompilerAssemblyPath.TabIndex = 13;
            this.buttonCompilerAssemblyPath.Text = "Browse";
            this.buttonCompilerAssemblyPath.UseVisualStyleBackColor = true;
            this.buttonCompilerAssemblyPath.Click += new System.EventHandler(this.buttonCompilerAssemblyPath_Click);
            // 
            // textBoxLanguageMap
            // 
            this.textBoxLanguageMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLanguageMap.Location = new System.Drawing.Point(129, 120);
            this.textBoxLanguageMap.Name = "textBoxLanguageMap";
            this.textBoxLanguageMap.Size = new System.Drawing.Size(221, 20);
            this.textBoxLanguageMap.TabIndex = 14;
            // 
            // textBoxUserMetadata
            // 
            this.textBoxUserMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserMetadata.Location = new System.Drawing.Point(129, 149);
            this.textBoxUserMetadata.Name = "textBoxUserMetadata";
            this.textBoxUserMetadata.Size = new System.Drawing.Size(221, 20);
            this.textBoxUserMetadata.TabIndex = 16;
            // 
            // buttonLanguageMap
            // 
            this.buttonLanguageMap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLanguageMap.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLanguageMap.Location = new System.Drawing.Point(356, 119);
            this.buttonLanguageMap.Name = "buttonLanguageMap";
            this.buttonLanguageMap.Size = new System.Drawing.Size(74, 23);
            this.buttonLanguageMap.TabIndex = 15;
            this.buttonLanguageMap.Text = "Browse";
            this.buttonLanguageMap.UseVisualStyleBackColor = true;
            this.buttonLanguageMap.Click += new System.EventHandler(this.buttonLanguageMap_Click);
            // 
            // buttonUserMetadata
            // 
            this.buttonUserMetadata.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUserMetadata.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUserMetadata.Location = new System.Drawing.Point(356, 148);
            this.buttonUserMetadata.Name = "buttonUserMetadata";
            this.buttonUserMetadata.Size = new System.Drawing.Size(74, 23);
            this.buttonUserMetadata.TabIndex = 17;
            this.buttonUserMetadata.Text = "Browse";
            this.buttonUserMetadata.UseVisualStyleBackColor = true;
            this.buttonUserMetadata.Click += new System.EventHandler(this.buttonUserMetadata_Click);
            // 
            // tabPageNaming
            // 
            this.tabPageNaming.Controls.Add(this.tabControlNaming);
            this.tabPageNaming.Location = new System.Drawing.Point(4, 22);
            this.tabPageNaming.Name = "tabPageNaming";
            this.tabPageNaming.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNaming.Size = new System.Drawing.Size(443, 473);
            this.tabPageNaming.TabIndex = 2;
            this.tabPageNaming.Text = "Naming Conventions";
            this.tabPageNaming.UseVisualStyleBackColor = true;
            // 
            // tabControlNaming
            // 
            this.tabControlNaming.Controls.Add(this.tabPageClass);
            this.tabControlNaming.Controls.Add(this.tabPageSP);
            this.tabControlNaming.Controls.Add(this.tabPageHierarchical);
            this.tabControlNaming.Controls.Add(this.tabPageMisc);
            this.tabControlNaming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNaming.Location = new System.Drawing.Point(3, 3);
            this.tabControlNaming.Multiline = true;
            this.tabControlNaming.Name = "tabControlNaming";
            this.tabControlNaming.SelectedIndex = 0;
            this.tabControlNaming.Size = new System.Drawing.Size(437, 467);
            this.tabControlNaming.TabIndex = 0;
            // 
            // tabPageClass
            // 
            this.tabPageClass.Controls.Add(this.tableLayoutPanel1);
            this.tabPageClass.Location = new System.Drawing.Point(4, 22);
            this.tabPageClass.Name = "tabPageClass";
            this.tabPageClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClass.Size = new System.Drawing.Size(429, 441);
            this.tabPageClass.TabIndex = 0;
            this.tabPageClass.Text = "Class Names";
            this.tabPageClass.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(labelAbstractPrefix, 0, 0);
            this.tableLayoutPanel1.Controls.Add(labelEntitySuffix, 0, 1);
            this.tableLayoutPanel1.Controls.Add(labelCollectionSuffix, 0, 2);
            this.tableLayoutPanel1.Controls.Add(labelQuerySuffix, 0, 3);
            this.tableLayoutPanel1.Controls.Add(labelMetadataSuffix, 0, 4);
            this.tableLayoutPanel1.Controls.Add(labelProxyStubSuffix, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProxyStubSuffix, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMetadataSuffix, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxQuerySuffix, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCollectionSuffix, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEntitySuffix, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAbstractPrefix, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkboxPrefixWithSchema, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 435);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxProxyStubSuffix
            // 
            this.textBoxProxyStubSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProxyStubSuffix.Location = new System.Drawing.Point(123, 133);
            this.textBoxProxyStubSuffix.Name = "textBoxProxyStubSuffix";
            this.textBoxProxyStubSuffix.Size = new System.Drawing.Size(266, 20);
            this.textBoxProxyStubSuffix.TabIndex = 11;
            // 
            // textBoxMetadataSuffix
            // 
            this.textBoxMetadataSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMetadataSuffix.Location = new System.Drawing.Point(123, 107);
            this.textBoxMetadataSuffix.Name = "textBoxMetadataSuffix";
            this.textBoxMetadataSuffix.Size = new System.Drawing.Size(266, 20);
            this.textBoxMetadataSuffix.TabIndex = 10;
            // 
            // textBoxQuerySuffix
            // 
            this.textBoxQuerySuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuerySuffix.Location = new System.Drawing.Point(123, 81);
            this.textBoxQuerySuffix.Name = "textBoxQuerySuffix";
            this.textBoxQuerySuffix.Size = new System.Drawing.Size(266, 20);
            this.textBoxQuerySuffix.TabIndex = 9;
            // 
            // textBoxCollectionSuffix
            // 
            this.textBoxCollectionSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCollectionSuffix.Location = new System.Drawing.Point(123, 55);
            this.textBoxCollectionSuffix.Name = "textBoxCollectionSuffix";
            this.textBoxCollectionSuffix.Size = new System.Drawing.Size(266, 20);
            this.textBoxCollectionSuffix.TabIndex = 8;
            // 
            // textBoxEntitySuffix
            // 
            this.textBoxEntitySuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEntitySuffix.Location = new System.Drawing.Point(123, 29);
            this.textBoxEntitySuffix.Name = "textBoxEntitySuffix";
            this.textBoxEntitySuffix.Size = new System.Drawing.Size(266, 20);
            this.textBoxEntitySuffix.TabIndex = 7;
            // 
            // textBoxAbstractPrefix
            // 
            this.textBoxAbstractPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAbstractPrefix.Location = new System.Drawing.Point(123, 3);
            this.textBoxAbstractPrefix.Name = "textBoxAbstractPrefix";
            this.textBoxAbstractPrefix.Size = new System.Drawing.Size(266, 20);
            this.textBoxAbstractPrefix.TabIndex = 6;
            // 
            // checkboxPrefixWithSchema
            // 
            this.checkboxPrefixWithSchema.AutoSize = true;
            this.checkboxPrefixWithSchema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkboxPrefixWithSchema.Location = new System.Drawing.Point(123, 164);
            this.checkboxPrefixWithSchema.Name = "checkboxPrefixWithSchema";
            this.checkboxPrefixWithSchema.Size = new System.Drawing.Size(266, 14);
            this.checkboxPrefixWithSchema.TabIndex = 12;
            this.tooltipPrefix.SetToolTip(this.checkboxPrefixWithSchema, "For advanced users only");
            this.checkboxPrefixWithSchema.UseVisualStyleBackColor = true;
            // 
            // tabPageSP
            // 
            this.tabPageSP.Controls.Add(tableLayoutPanel3);
            this.tabPageSP.Location = new System.Drawing.Point(4, 22);
            this.tabPageSP.Name = "tabPageSP";
            this.tabPageSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSP.Size = new System.Drawing.Size(429, 441);
            this.tabPageSP.TabIndex = 1;
            this.tabPageSP.Text = "Stored Procedure";
            this.tabPageSP.UseVisualStyleBackColor = true;
            // 
            // tabPageHierarchical
            // 
            this.tabPageHierarchical.Controls.Add(this.tableLayoutPanel4);
            this.tabPageHierarchical.Location = new System.Drawing.Point(4, 22);
            this.tabPageHierarchical.Name = "tabPageHierarchical";
            this.tabPageHierarchical.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHierarchical.Size = new System.Drawing.Size(429, 441);
            this.tabPageHierarchical.TabIndex = 2;
            this.tabPageHierarchical.Text = "Hierarchical";
            this.tabPageHierarchical.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel4.Controls.Add(this.labelHierPrefix, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelHierSuffix, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelHierSeparator, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelHierEntity, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelHierCollection, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelHierTable1, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelHierTable2, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelHierColumn1, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelHierColumn2, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxOnePrefix, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxOneSuffix, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxOneSeparator, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxManyPrefix, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxManySuffix, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxManySeparator, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxSelfOnly, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxSwapNames, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxUseAssociativeName, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxUseUpToPrefix, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.labelSample, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.labelHierSample, 2, 8);
            this.tableLayoutPanel4.Controls.Add(this.labelHierTypes, 1, 8);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(423, 435);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // labelHierPrefix
            // 
            this.labelHierPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHierPrefix.AutoSize = true;
            this.labelHierPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHierPrefix.Location = new System.Drawing.Point(68, 0);
            this.labelHierPrefix.Name = "labelHierPrefix";
            this.labelHierPrefix.Size = new System.Drawing.Size(28, 26);
            this.labelHierPrefix.TabIndex = 0;
            this.labelHierPrefix.Text = "Prefix";
            this.labelHierPrefix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHierSuffix
            // 
            this.labelHierSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHierSuffix.AutoSize = true;
            this.labelHierSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHierSuffix.Location = new System.Drawing.Point(162, 0);
            this.labelHierSuffix.Name = "labelHierSuffix";
            this.labelHierSuffix.Size = new System.Drawing.Size(28, 26);
            this.labelHierSuffix.TabIndex = 1;
            this.labelHierSuffix.Text = "Suffix";
            this.labelHierSuffix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHierSeparator
            // 
            this.labelHierSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHierSeparator.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.labelHierSeparator, 2);
            this.labelHierSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHierSeparator.Location = new System.Drawing.Point(196, 6);
            this.labelHierSeparator.Name = "labelHierSeparator";
            this.labelHierSeparator.Size = new System.Drawing.Size(224, 13);
            this.labelHierSeparator.TabIndex = 2;
            this.labelHierSeparator.Text = "Separator";
            // 
            // labelHierEntity
            // 
            this.labelHierEntity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHierEntity.AutoSize = true;
            this.labelHierEntity.Location = new System.Drawing.Point(26, 32);
            this.labelHierEntity.Name = "labelHierEntity";
            this.labelHierEntity.Size = new System.Drawing.Size(36, 13);
            this.labelHierEntity.TabIndex = 3;
            this.labelHierEntity.Text = "Entity:";
            // 
            // labelHierCollection
            // 
            this.labelHierCollection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHierCollection.AutoSize = true;
            this.labelHierCollection.Location = new System.Drawing.Point(6, 58);
            this.labelHierCollection.Name = "labelHierCollection";
            this.labelHierCollection.Size = new System.Drawing.Size(56, 13);
            this.labelHierCollection.TabIndex = 4;
            this.labelHierCollection.Text = "Collection:";
            // 
            // labelHierTable1
            // 
            this.labelHierTable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHierTable1.AutoSize = true;
            this.labelHierTable1.Location = new System.Drawing.Point(102, 32);
            this.labelHierTable1.Name = "labelHierTable1";
            this.labelHierTable1.Size = new System.Drawing.Size(54, 13);
            this.labelHierTable1.TabIndex = 5;
            this.labelHierTable1.Text = "Table";
            this.labelHierTable1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHierTable2
            // 
            this.labelHierTable2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHierTable2.AutoSize = true;
            this.labelHierTable2.Location = new System.Drawing.Point(102, 58);
            this.labelHierTable2.Name = "labelHierTable2";
            this.labelHierTable2.Size = new System.Drawing.Size(54, 13);
            this.labelHierTable2.TabIndex = 6;
            this.labelHierTable2.Text = "Table";
            this.labelHierTable2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHierColumn1
            // 
            this.labelHierColumn1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHierColumn1.AutoSize = true;
            this.labelHierColumn1.Location = new System.Drawing.Point(208, 32);
            this.labelHierColumn1.Name = "labelHierColumn1";
            this.labelHierColumn1.Size = new System.Drawing.Size(42, 13);
            this.labelHierColumn1.TabIndex = 7;
            this.labelHierColumn1.Text = "Column";
            // 
            // labelHierColumn2
            // 
            this.labelHierColumn2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHierColumn2.AutoSize = true;
            this.labelHierColumn2.Location = new System.Drawing.Point(208, 58);
            this.labelHierColumn2.Name = "labelHierColumn2";
            this.labelHierColumn2.Size = new System.Drawing.Size(42, 13);
            this.labelHierColumn2.TabIndex = 8;
            this.labelHierColumn2.Text = "Column";
            // 
            // textBoxOnePrefix
            // 
            this.textBoxOnePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOnePrefix.Location = new System.Drawing.Point(68, 29);
            this.textBoxOnePrefix.Name = "textBoxOnePrefix";
            this.textBoxOnePrefix.Size = new System.Drawing.Size(28, 20);
            this.textBoxOnePrefix.TabIndex = 9;
            this.textBoxOnePrefix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HierarchicalTextBox_KeyUp);
            // 
            // textBoxOneSuffix
            // 
            this.textBoxOneSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOneSuffix.Location = new System.Drawing.Point(162, 29);
            this.textBoxOneSuffix.Name = "textBoxOneSuffix";
            this.textBoxOneSuffix.Size = new System.Drawing.Size(28, 20);
            this.textBoxOneSuffix.TabIndex = 10;
            this.textBoxOneSuffix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HierarchicalTextBox_KeyUp);
            // 
            // textBoxOneSeparator
            // 
            this.textBoxOneSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOneSeparator.Location = new System.Drawing.Point(196, 29);
            this.textBoxOneSeparator.Name = "textBoxOneSeparator";
            this.textBoxOneSeparator.Size = new System.Drawing.Size(6, 20);
            this.textBoxOneSeparator.TabIndex = 11;
            this.textBoxOneSeparator.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HierarchicalTextBox_KeyUp);
            // 
            // textBoxManyPrefix
            // 
            this.textBoxManyPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManyPrefix.Location = new System.Drawing.Point(68, 55);
            this.textBoxManyPrefix.Name = "textBoxManyPrefix";
            this.textBoxManyPrefix.Size = new System.Drawing.Size(28, 20);
            this.textBoxManyPrefix.TabIndex = 12;
            this.textBoxManyPrefix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HierarchicalTextBox_KeyUp);
            // 
            // textBoxManySuffix
            // 
            this.textBoxManySuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManySuffix.Location = new System.Drawing.Point(162, 55);
            this.textBoxManySuffix.Name = "textBoxManySuffix";
            this.textBoxManySuffix.Size = new System.Drawing.Size(28, 20);
            this.textBoxManySuffix.TabIndex = 13;
            this.textBoxManySuffix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HierarchicalTextBox_KeyUp);
            // 
            // textBoxManySeparator
            // 
            this.textBoxManySeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxManySeparator.Location = new System.Drawing.Point(196, 55);
            this.textBoxManySeparator.Name = "textBoxManySeparator";
            this.textBoxManySeparator.Size = new System.Drawing.Size(6, 20);
            this.textBoxManySeparator.TabIndex = 14;
            this.textBoxManySeparator.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HierarchicalTextBox_KeyUp);
            // 
            // checkBoxSelfOnly
            // 
            this.checkBoxSelfOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSelfOnly.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.checkBoxSelfOnly, 4);
            this.checkBoxSelfOnly.Location = new System.Drawing.Point(68, 81);
            this.checkBoxSelfOnly.Name = "checkBoxSelfOnly";
            this.checkBoxSelfOnly.Size = new System.Drawing.Size(134, 17);
            this.checkBoxSelfOnly.TabIndex = 15;
            this.checkBoxSelfOnly.Text = "Use Suffix on Self-Referencing only.";
            this.checkBoxSelfOnly.UseVisualStyleBackColor = true;
            this.checkBoxSelfOnly.CheckedChanged += new System.EventHandler(this.checkBoxSelfOnly_CheckedChanged);
            // 
            // checkBoxSwapNames
            // 
            this.checkBoxSwapNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSwapNames.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.checkBoxSwapNames, 4);
            this.checkBoxSwapNames.Location = new System.Drawing.Point(68, 104);
            this.checkBoxSwapNames.Name = "checkBoxSwapNames";
            this.checkBoxSwapNames.Size = new System.Drawing.Size(134, 17);
            this.checkBoxSwapNames.TabIndex = 16;
            this.checkBoxSwapNames.Text = "Swap the Table and Column Names.";
            this.checkBoxSwapNames.UseVisualStyleBackColor = true;
            this.checkBoxSwapNames.CheckedChanged += new System.EventHandler(this.checkBoxSwapNames_CheckedChanged);
            // 
            // checkBoxUseAssociativeName
            // 
            this.checkBoxUseAssociativeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseAssociativeName.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.checkBoxUseAssociativeName, 4);
            this.checkBoxUseAssociativeName.Location = new System.Drawing.Point(68, 127);
            this.checkBoxUseAssociativeName.Name = "checkBoxUseAssociativeName";
            this.checkBoxUseAssociativeName.Size = new System.Drawing.Size(134, 17);
            this.checkBoxUseAssociativeName.TabIndex = 17;
            this.checkBoxUseAssociativeName.Text = "Use the associative table name for ManyToMany.";
            this.checkBoxUseAssociativeName.UseVisualStyleBackColor = true;
            this.checkBoxUseAssociativeName.CheckedChanged += new System.EventHandler(this.checkBoxUseAssociativeName_CheckedChanged);
            // 
            // checkBoxUseUpToPrefix
            // 
            this.checkBoxUseUpToPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseUpToPrefix.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.checkBoxUseUpToPrefix, 4);
            this.checkBoxUseUpToPrefix.Location = new System.Drawing.Point(68, 150);
            this.checkBoxUseUpToPrefix.Name = "checkBoxUseUpToPrefix";
            this.checkBoxUseUpToPrefix.Size = new System.Drawing.Size(134, 17);
            this.checkBoxUseUpToPrefix.TabIndex = 18;
            this.checkBoxUseUpToPrefix.Text = "Prefix Parent names with \'UpTo\'.";
            this.checkBoxUseUpToPrefix.UseVisualStyleBackColor = true;
            this.checkBoxUseUpToPrefix.CheckedChanged += new System.EventHandler(this.checkBoxUseUpToPrefix_CheckedChanged);
            // 
            // labelSample
            // 
            this.labelSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSample.AutoSize = true;
            this.labelSample.Location = new System.Drawing.Point(17, 190);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(45, 13);
            this.labelSample.TabIndex = 19;
            this.labelSample.Text = "Sample:";
            // 
            // labelHierSample
            // 
            this.labelHierSample.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.labelHierSample, 4);
            this.labelHierSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHierSample.Location = new System.Drawing.Point(102, 190);
            this.labelHierSample.Name = "labelHierSample";
            this.labelHierSample.Size = new System.Drawing.Size(318, 245);
            this.labelHierSample.TabIndex = 20;
            // 
            // labelHierTypes
            // 
            this.labelHierTypes.AutoSize = true;
            this.labelHierTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHierTypes.Location = new System.Drawing.Point(68, 190);
            this.labelHierTypes.Name = "labelHierTypes";
            this.labelHierTypes.Size = new System.Drawing.Size(28, 245);
            this.labelHierTypes.TabIndex = 21;
            // 
            // tabPageMisc
            // 
            this.tabPageMisc.Controls.Add(this.tableLayoutPanel2);
            this.tabPageMisc.Location = new System.Drawing.Point(4, 22);
            this.tabPageMisc.Name = "tabPageMisc";
            this.tabPageMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMisc.Size = new System.Drawing.Size(429, 441);
            this.tabPageMisc.TabIndex = 3;
            this.tabPageMisc.Text = "Miscellaneous";
            this.tabPageMisc.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxUseRawNames, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxPreserveUnderscores, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(423, 435);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // checkBoxUseRawNames
            // 
            this.checkBoxUseRawNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseRawNames.AutoSize = true;
            this.checkBoxUseRawNames.Location = new System.Drawing.Point(93, 26);
            this.checkBoxUseRawNames.Name = "checkBoxUseRawNames";
            this.checkBoxUseRawNames.Size = new System.Drawing.Size(293, 17);
            this.checkBoxUseRawNames.TabIndex = 2;
            this.checkBoxUseRawNames.Text = "Use raw names (not recommended)";
            this.tooltipPrefix.SetToolTip(this.checkBoxUseRawNames, "This should be left as unchecked");
            this.checkBoxUseRawNames.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreserveUnderscores
            // 
            this.checkBoxPreserveUnderscores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPreserveUnderscores.AutoSize = true;
            this.checkBoxPreserveUnderscores.Location = new System.Drawing.Point(93, 3);
            this.checkBoxPreserveUnderscores.Name = "checkBoxPreserveUnderscores";
            this.checkBoxPreserveUnderscores.Size = new System.Drawing.Size(293, 17);
            this.checkBoxPreserveUnderscores.TabIndex = 3;
            this.checkBoxPreserveUnderscores.Text = "Preserve Underscores";
            this.checkBoxPreserveUnderscores.UseVisualStyleBackColor = true;
            // 
            // tabPageFields
            // 
            this.tabPageFields.Controls.Add(this.tableLayoutPanel10);
            this.tabPageFields.Location = new System.Drawing.Point(4, 22);
            this.tabPageFields.Name = "tabPageFields";
            this.tabPageFields.Size = new System.Drawing.Size(443, 473);
            this.tabPageFields.TabIndex = 5;
            this.tabPageFields.Text = "Custom Fields";
            this.tabPageFields.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel10.Controls.Add(label11, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.lblSelectedDriver, 1, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(443, 473);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel10.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 33);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 455);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel20);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(429, 429);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Dates";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(423, 423);
            this.tableLayoutPanel20.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel21);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 99);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date Added:";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Controls.Add(this.txtDateAddedServerSideText, 1, 1);
            this.tableLayoutPanel21.Controls.Add(this.txtDateAddedColumnName, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.chkDateAddedEnabled, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.chkDateAddedServerSideEnabled, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.chkDateAddedClientSideEnabled, 0, 2);
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel22, 1, 2);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 3;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(411, 80);
            this.tableLayoutPanel21.TabIndex = 0;
            // 
            // txtDateAddedServerSideText
            // 
            this.txtDateAddedServerSideText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateAddedServerSideText.Location = new System.Drawing.Point(153, 29);
            this.txtDateAddedServerSideText.Name = "txtDateAddedServerSideText";
            this.txtDateAddedServerSideText.Size = new System.Drawing.Size(255, 20);
            this.txtDateAddedServerSideText.TabIndex = 3;
            // 
            // txtDateAddedColumnName
            // 
            this.txtDateAddedColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateAddedColumnName.Enabled = false;
            this.txtDateAddedColumnName.Location = new System.Drawing.Point(153, 3);
            this.txtDateAddedColumnName.Name = "txtDateAddedColumnName";
            this.txtDateAddedColumnName.Size = new System.Drawing.Size(255, 20);
            this.txtDateAddedColumnName.TabIndex = 2;
            this.txtDateAddedColumnName.Text = "DateAdded";
            // 
            // chkDateAddedEnabled
            // 
            this.chkDateAddedEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDateAddedEnabled.AutoSize = true;
            this.chkDateAddedEnabled.Location = new System.Drawing.Point(25, 4);
            this.chkDateAddedEnabled.Name = "chkDateAddedEnabled";
            this.chkDateAddedEnabled.Size = new System.Drawing.Size(122, 17);
            this.chkDateAddedEnabled.TabIndex = 0;
            this.chkDateAddedEnabled.Text = "Enable Date Added:";
            this.chkDateAddedEnabled.UseVisualStyleBackColor = true;
            this.chkDateAddedEnabled.CheckedChanged += new System.EventHandler(this.chkDateAddedEnabled_CheckedChanged);
            // 
            // chkDateAddedServerSideEnabled
            // 
            this.chkDateAddedServerSideEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDateAddedServerSideEnabled.AutoSize = true;
            this.chkDateAddedServerSideEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDateAddedServerSideEnabled.Checked = true;
            this.chkDateAddedServerSideEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateAddedServerSideEnabled.Enabled = false;
            this.chkDateAddedServerSideEnabled.Location = new System.Drawing.Point(39, 30);
            this.chkDateAddedServerSideEnabled.Name = "chkDateAddedServerSideEnabled";
            this.chkDateAddedServerSideEnabled.Size = new System.Drawing.Size(108, 17);
            this.chkDateAddedServerSideEnabled.TabIndex = 0;
            this.chkDateAddedServerSideEnabled.Text = "Server Side SQL:";
            this.chkDateAddedServerSideEnabled.UseVisualStyleBackColor = true;
            this.chkDateAddedServerSideEnabled.CheckedChanged += new System.EventHandler(this.chkDateAddedServerSideEnabled_CheckedChanged);
            // 
            // chkDateAddedClientSideEnabled
            // 
            this.chkDateAddedClientSideEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDateAddedClientSideEnabled.AutoSize = true;
            this.chkDateAddedClientSideEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDateAddedClientSideEnabled.Enabled = false;
            this.chkDateAddedClientSideEnabled.Location = new System.Drawing.Point(68, 57);
            this.chkDateAddedClientSideEnabled.Name = "chkDateAddedClientSideEnabled";
            this.chkDateAddedClientSideEnabled.Size = new System.Drawing.Size(79, 17);
            this.chkDateAddedClientSideEnabled.TabIndex = 0;
            this.chkDateAddedClientSideEnabled.Text = "Client Side:";
            this.chkDateAddedClientSideEnabled.UseVisualStyleBackColor = true;
            this.chkDateAddedClientSideEnabled.CheckedChanged += new System.EventHandler(this.chkDateAddedClientSideEnabled_CheckedChanged);
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 2;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel22.Controls.Add(this.rdoDateAddedClientSideUtcNow, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.rdoDateAddedClientSideNow, 0, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(153, 55);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel22.Size = new System.Drawing.Size(255, 22);
            this.tableLayoutPanel22.TabIndex = 4;
            // 
            // rdoDateAddedClientSideUtcNow
            // 
            this.rdoDateAddedClientSideUtcNow.AutoSize = true;
            this.rdoDateAddedClientSideUtcNow.Enabled = false;
            this.rdoDateAddedClientSideUtcNow.Location = new System.Drawing.Point(56, 3);
            this.rdoDateAddedClientSideUtcNow.Name = "rdoDateAddedClientSideUtcNow";
            this.rdoDateAddedClientSideUtcNow.Size = new System.Drawing.Size(64, 17);
            this.rdoDateAddedClientSideUtcNow.TabIndex = 4;
            this.rdoDateAddedClientSideUtcNow.Text = "UtcNow";
            this.rdoDateAddedClientSideUtcNow.UseVisualStyleBackColor = true;
            // 
            // rdoDateAddedClientSideNow
            // 
            this.rdoDateAddedClientSideNow.AutoSize = true;
            this.rdoDateAddedClientSideNow.Checked = true;
            this.rdoDateAddedClientSideNow.Enabled = false;
            this.rdoDateAddedClientSideNow.Location = new System.Drawing.Point(3, 3);
            this.rdoDateAddedClientSideNow.Name = "rdoDateAddedClientSideNow";
            this.rdoDateAddedClientSideNow.Size = new System.Drawing.Size(47, 17);
            this.rdoDateAddedClientSideNow.TabIndex = 4;
            this.rdoDateAddedClientSideNow.TabStop = true;
            this.rdoDateAddedClientSideNow.Text = "Now";
            this.rdoDateAddedClientSideNow.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel23);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(3, 108);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(417, 103);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Date Modified:";
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Controls.Add(this.txtDateModifiedServerSideText, 1, 1);
            this.tableLayoutPanel23.Controls.Add(this.txtDateModifiedColumnName, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.chkDateModifiedEnabled, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.chkDateModifiedServerSideEnabled, 0, 1);
            this.tableLayoutPanel23.Controls.Add(this.chkDateModifiedClientSideEnabled, 0, 2);
            this.tableLayoutPanel23.Controls.Add(this.tableLayoutPanel24, 1, 2);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 3;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.Size = new System.Drawing.Size(411, 84);
            this.tableLayoutPanel23.TabIndex = 0;
            // 
            // txtDateModifiedServerSideText
            // 
            this.txtDateModifiedServerSideText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateModifiedServerSideText.Location = new System.Drawing.Point(153, 29);
            this.txtDateModifiedServerSideText.Name = "txtDateModifiedServerSideText";
            this.txtDateModifiedServerSideText.Size = new System.Drawing.Size(255, 20);
            this.txtDateModifiedServerSideText.TabIndex = 3;
            // 
            // txtDateModifiedColumnName
            // 
            this.txtDateModifiedColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateModifiedColumnName.Enabled = false;
            this.txtDateModifiedColumnName.Location = new System.Drawing.Point(153, 3);
            this.txtDateModifiedColumnName.Name = "txtDateModifiedColumnName";
            this.txtDateModifiedColumnName.Size = new System.Drawing.Size(255, 20);
            this.txtDateModifiedColumnName.TabIndex = 2;
            this.txtDateModifiedColumnName.Text = "DateModified";
            // 
            // chkDateModifiedEnabled
            // 
            this.chkDateModifiedEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDateModifiedEnabled.AutoSize = true;
            this.chkDateModifiedEnabled.Location = new System.Drawing.Point(16, 4);
            this.chkDateModifiedEnabled.Name = "chkDateModifiedEnabled";
            this.chkDateModifiedEnabled.Size = new System.Drawing.Size(131, 17);
            this.chkDateModifiedEnabled.TabIndex = 0;
            this.chkDateModifiedEnabled.Text = "Enable Date Modified:";
            this.chkDateModifiedEnabled.UseVisualStyleBackColor = true;
            this.chkDateModifiedEnabled.CheckedChanged += new System.EventHandler(this.chkDateModifiedEnabled_CheckedChanged);
            // 
            // chkDateModifiedServerSideEnabled
            // 
            this.chkDateModifiedServerSideEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDateModifiedServerSideEnabled.AutoSize = true;
            this.chkDateModifiedServerSideEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDateModifiedServerSideEnabled.Checked = true;
            this.chkDateModifiedServerSideEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateModifiedServerSideEnabled.Enabled = false;
            this.chkDateModifiedServerSideEnabled.Location = new System.Drawing.Point(39, 30);
            this.chkDateModifiedServerSideEnabled.Name = "chkDateModifiedServerSideEnabled";
            this.chkDateModifiedServerSideEnabled.Size = new System.Drawing.Size(108, 17);
            this.chkDateModifiedServerSideEnabled.TabIndex = 0;
            this.chkDateModifiedServerSideEnabled.Text = "Server Side SQL:";
            this.chkDateModifiedServerSideEnabled.UseVisualStyleBackColor = true;
            this.chkDateModifiedServerSideEnabled.CheckedChanged += new System.EventHandler(this.chkDateModifiedServerSideEnabled_CheckedChanged);
            // 
            // chkDateModifiedClientSideEnabled
            // 
            this.chkDateModifiedClientSideEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDateModifiedClientSideEnabled.AutoSize = true;
            this.chkDateModifiedClientSideEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDateModifiedClientSideEnabled.Enabled = false;
            this.chkDateModifiedClientSideEnabled.Location = new System.Drawing.Point(68, 60);
            this.chkDateModifiedClientSideEnabled.Name = "chkDateModifiedClientSideEnabled";
            this.chkDateModifiedClientSideEnabled.Size = new System.Drawing.Size(79, 17);
            this.chkDateModifiedClientSideEnabled.TabIndex = 0;
            this.chkDateModifiedClientSideEnabled.Text = "Client Side:";
            this.chkDateModifiedClientSideEnabled.UseVisualStyleBackColor = true;
            this.chkDateModifiedClientSideEnabled.CheckedChanged += new System.EventHandler(this.chkDateModifiedClientSideEnabled_CheckedChanged);
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 2;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel24.Controls.Add(this.rdoDateModifiedClientSideUtcNow, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.rdoDateModifiedClientSideNow, 0, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(153, 55);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel24.Size = new System.Drawing.Size(255, 27);
            this.tableLayoutPanel24.TabIndex = 4;
            // 
            // rdoDateModifiedClientSideUtcNow
            // 
            this.rdoDateModifiedClientSideUtcNow.AutoSize = true;
            this.rdoDateModifiedClientSideUtcNow.Enabled = false;
            this.rdoDateModifiedClientSideUtcNow.Location = new System.Drawing.Point(56, 3);
            this.rdoDateModifiedClientSideUtcNow.Name = "rdoDateModifiedClientSideUtcNow";
            this.rdoDateModifiedClientSideUtcNow.Size = new System.Drawing.Size(64, 17);
            this.rdoDateModifiedClientSideUtcNow.TabIndex = 4;
            this.rdoDateModifiedClientSideUtcNow.Text = "UtcNow";
            this.rdoDateModifiedClientSideUtcNow.UseVisualStyleBackColor = true;
            // 
            // rdoDateModifiedClientSideNow
            // 
            this.rdoDateModifiedClientSideNow.AutoSize = true;
            this.rdoDateModifiedClientSideNow.Checked = true;
            this.rdoDateModifiedClientSideNow.Enabled = false;
            this.rdoDateModifiedClientSideNow.Location = new System.Drawing.Point(3, 3);
            this.rdoDateModifiedClientSideNow.Name = "rdoDateModifiedClientSideNow";
            this.rdoDateModifiedClientSideNow.Size = new System.Drawing.Size(47, 17);
            this.rdoDateModifiedClientSideNow.TabIndex = 4;
            this.rdoDateModifiedClientSideNow.TabStop = true;
            this.rdoDateModifiedClientSideNow.Text = "Now";
            this.rdoDateModifiedClientSideNow.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel25);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(429, 429);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "UserID\'s";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 1;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Controls.Add(this.groupBox8, 0, 1);
            this.tableLayoutPanel25.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 3;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(423, 423);
            this.tableLayoutPanel25.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.tableLayoutPanel27);
            this.groupBox8.Location = new System.Drawing.Point(3, 105);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(417, 94);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Modified By:";
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 2;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Controls.Add(this.txtModifiedByColumnName, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.txtModifiedByServerSideText, 1, 1);
            this.tableLayoutPanel27.Controls.Add(this.chkModifiedByEnabled, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.chkModifiedByServerSide, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.chkModifiedByEventHandler, 0, 2);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 3;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.Size = new System.Drawing.Size(411, 75);
            this.tableLayoutPanel27.TabIndex = 0;
            // 
            // txtModifiedByColumnName
            // 
            this.txtModifiedByColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModifiedByColumnName.Enabled = false;
            this.txtModifiedByColumnName.Location = new System.Drawing.Point(153, 3);
            this.txtModifiedByColumnName.Name = "txtModifiedByColumnName";
            this.txtModifiedByColumnName.Size = new System.Drawing.Size(255, 20);
            this.txtModifiedByColumnName.TabIndex = 2;
            this.txtModifiedByColumnName.Text = "ModifiedBy";
            // 
            // txtModifiedByServerSideText
            // 
            this.txtModifiedByServerSideText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModifiedByServerSideText.Enabled = false;
            this.txtModifiedByServerSideText.Location = new System.Drawing.Point(153, 29);
            this.txtModifiedByServerSideText.Name = "txtModifiedByServerSideText";
            this.txtModifiedByServerSideText.Size = new System.Drawing.Size(255, 20);
            this.txtModifiedByServerSideText.TabIndex = 8;
            // 
            // chkModifiedByEnabled
            // 
            this.chkModifiedByEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkModifiedByEnabled.AutoSize = true;
            this.chkModifiedByEnabled.Location = new System.Drawing.Point(27, 4);
            this.chkModifiedByEnabled.Name = "chkModifiedByEnabled";
            this.chkModifiedByEnabled.Size = new System.Drawing.Size(120, 17);
            this.chkModifiedByEnabled.TabIndex = 0;
            this.chkModifiedByEnabled.Text = "Enable Modified By:";
            this.chkModifiedByEnabled.UseVisualStyleBackColor = true;
            this.chkModifiedByEnabled.CheckedChanged += new System.EventHandler(this.chkModifiedByEnabled_CheckedChanged);
            // 
            // chkModifiedByServerSide
            // 
            this.chkModifiedByServerSide.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkModifiedByServerSide.AutoSize = true;
            this.chkModifiedByServerSide.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkModifiedByServerSide.Enabled = false;
            this.chkModifiedByServerSide.Location = new System.Drawing.Point(39, 30);
            this.chkModifiedByServerSide.Name = "chkModifiedByServerSide";
            this.chkModifiedByServerSide.Size = new System.Drawing.Size(108, 17);
            this.chkModifiedByServerSide.TabIndex = 9;
            this.chkModifiedByServerSide.Text = "Server Side SQL:";
            this.chkModifiedByServerSide.UseVisualStyleBackColor = true;
            this.chkModifiedByServerSide.CheckedChanged += new System.EventHandler(this.chkModifiedByServerSide_CheckedChanged);
            // 
            // chkModifiedByEventHandler
            // 
            this.chkModifiedByEventHandler.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkModifiedByEventHandler.AutoSize = true;
            this.chkModifiedByEventHandler.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkModifiedByEventHandler.Checked = true;
            this.chkModifiedByEventHandler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModifiedByEventHandler.Enabled = false;
            this.chkModifiedByEventHandler.Location = new System.Drawing.Point(50, 55);
            this.chkModifiedByEventHandler.Name = "chkModifiedByEventHandler";
            this.chkModifiedByEventHandler.Size = new System.Drawing.Size(97, 17);
            this.chkModifiedByEventHandler.TabIndex = 9;
            this.chkModifiedByEventHandler.Text = "Event Handler:";
            this.chkModifiedByEventHandler.UseVisualStyleBackColor = true;
            this.chkModifiedByEventHandler.CheckedChanged += new System.EventHandler(this.chkModifiedByEventHandler_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel26);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(417, 96);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Added By:";
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 2;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Controls.Add(this.txtAddedByColumnName, 1, 0);
            this.tableLayoutPanel26.Controls.Add(this.txtAddedByServerSideText, 1, 1);
            this.tableLayoutPanel26.Controls.Add(this.chkAddedByEnabled, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.chkAddedByServerSide, 0, 1);
            this.tableLayoutPanel26.Controls.Add(this.chkAddedByEventHandler, 0, 2);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 3;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel26.Size = new System.Drawing.Size(411, 77);
            this.tableLayoutPanel26.TabIndex = 0;
            // 
            // txtAddedByColumnName
            // 
            this.txtAddedByColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddedByColumnName.Enabled = false;
            this.txtAddedByColumnName.Location = new System.Drawing.Point(153, 3);
            this.txtAddedByColumnName.Name = "txtAddedByColumnName";
            this.txtAddedByColumnName.Size = new System.Drawing.Size(255, 20);
            this.txtAddedByColumnName.TabIndex = 2;
            this.txtAddedByColumnName.Text = "AddedBy";
            // 
            // txtAddedByServerSideText
            // 
            this.txtAddedByServerSideText.AcceptsReturn = true;
            this.txtAddedByServerSideText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddedByServerSideText.Enabled = false;
            this.txtAddedByServerSideText.Location = new System.Drawing.Point(153, 29);
            this.txtAddedByServerSideText.Name = "txtAddedByServerSideText";
            this.txtAddedByServerSideText.Size = new System.Drawing.Size(255, 20);
            this.txtAddedByServerSideText.TabIndex = 8;
            // 
            // chkAddedByEnabled
            // 
            this.chkAddedByEnabled.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkAddedByEnabled.AutoSize = true;
            this.chkAddedByEnabled.Location = new System.Drawing.Point(36, 4);
            this.chkAddedByEnabled.Name = "chkAddedByEnabled";
            this.chkAddedByEnabled.Size = new System.Drawing.Size(111, 17);
            this.chkAddedByEnabled.TabIndex = 0;
            this.chkAddedByEnabled.Text = "Enable Added By:";
            this.chkAddedByEnabled.UseVisualStyleBackColor = true;
            this.chkAddedByEnabled.CheckedChanged += new System.EventHandler(this.chkAddedByEnabled_CheckedChanged);
            // 
            // chkAddedByServerSide
            // 
            this.chkAddedByServerSide.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkAddedByServerSide.AutoSize = true;
            this.chkAddedByServerSide.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAddedByServerSide.Enabled = false;
            this.chkAddedByServerSide.Location = new System.Drawing.Point(39, 30);
            this.chkAddedByServerSide.Name = "chkAddedByServerSide";
            this.chkAddedByServerSide.Size = new System.Drawing.Size(108, 17);
            this.chkAddedByServerSide.TabIndex = 9;
            this.chkAddedByServerSide.Text = "Server Side SQL:";
            this.chkAddedByServerSide.UseVisualStyleBackColor = true;
            this.chkAddedByServerSide.CheckedChanged += new System.EventHandler(this.chkAddedByServerSide_CheckedChanged);
            // 
            // chkAddedByEventHandler
            // 
            this.chkAddedByEventHandler.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkAddedByEventHandler.AutoSize = true;
            this.chkAddedByEventHandler.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAddedByEventHandler.Checked = true;
            this.chkAddedByEventHandler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddedByEventHandler.Enabled = false;
            this.chkAddedByEventHandler.Location = new System.Drawing.Point(50, 56);
            this.chkAddedByEventHandler.Name = "chkAddedByEventHandler";
            this.chkAddedByEventHandler.Size = new System.Drawing.Size(97, 17);
            this.chkAddedByEventHandler.TabIndex = 9;
            this.chkAddedByEventHandler.Text = "Event Handler:";
            this.chkAddedByEventHandler.UseVisualStyleBackColor = true;
            this.chkAddedByEventHandler.CheckedChanged += new System.EventHandler(this.chkAddedByEventHandler_CheckedChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel28);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(429, 429);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Concurrency";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 2;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.Controls.Add(this.txtConcurrencyColumnName, 1, 0);
            this.tableLayoutPanel28.Controls.Add(this.chkConcurrencyColumn, 0, 0);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 2;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(429, 429);
            this.tableLayoutPanel28.TabIndex = 0;
            // 
            // txtConcurrencyColumnName
            // 
            this.txtConcurrencyColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcurrencyColumnName.Location = new System.Drawing.Point(153, 3);
            this.txtConcurrencyColumnName.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.txtConcurrencyColumnName.Name = "txtConcurrencyColumnName";
            this.txtConcurrencyColumnName.Size = new System.Drawing.Size(268, 20);
            this.txtConcurrencyColumnName.TabIndex = 8;
            // 
            // chkConcurrencyColumn
            // 
            this.chkConcurrencyColumn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkConcurrencyColumn.AutoSize = true;
            this.chkConcurrencyColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConcurrencyColumn.Location = new System.Drawing.Point(20, 4);
            this.chkConcurrencyColumn.Name = "chkConcurrencyColumn";
            this.chkConcurrencyColumn.Size = new System.Drawing.Size(127, 17);
            this.chkConcurrencyColumn.TabIndex = 9;
            this.chkConcurrencyColumn.Text = "Concurrency Column:";
            this.chkConcurrencyColumn.UseVisualStyleBackColor = true;
            this.chkConcurrencyColumn.CheckedChanged += new System.EventHandler(this.chkConcurrencyColumn_CheckedChanged);
            // 
            // lblSelectedDriver
            // 
            this.lblSelectedDriver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectedDriver.AutoSize = true;
            this.lblSelectedDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDriver.Location = new System.Drawing.Point(83, 13);
            this.lblSelectedDriver.Name = "lblSelectedDriver";
            this.lblSelectedDriver.Size = new System.Drawing.Size(37, 13);
            this.lblSelectedDriver.TabIndex = 9;
            this.lblSelectedDriver.Text = "None";
            this.lblSelectedDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageOther
            // 
            this.tabPageOther.Controls.Add(this.tableLayoutPanel6);
            this.tabPageOther.Location = new System.Drawing.Point(4, 22);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOther.Size = new System.Drawing.Size(443, 473);
            this.tabPageOther.TabIndex = 3;
            this.tabPageOther.Text = "Other";
            this.tabPageOther.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoScroll = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.groupBoxTemplateDoubleClick, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxUseNullableTypes, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxNoDatesInHeader, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(437, 467);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBoxTemplateDoubleClick
            // 
            this.groupBoxTemplateDoubleClick.AutoSize = true;
            this.groupBoxTemplateDoubleClick.Controls.Add(this.radioButtonExecuteWithLastSettings);
            this.groupBoxTemplateDoubleClick.Controls.Add(this.radioButtonExecute);
            this.groupBoxTemplateDoubleClick.Controls.Add(this.radioButtonEditTemplate);
            this.groupBoxTemplateDoubleClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTemplateDoubleClick.ForeColor = System.Drawing.Color.Black;
            this.groupBoxTemplateDoubleClick.Location = new System.Drawing.Point(2, 2);
            this.groupBoxTemplateDoubleClick.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTemplateDoubleClick.Name = "groupBoxTemplateDoubleClick";
            this.groupBoxTemplateDoubleClick.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTemplateDoubleClick.Size = new System.Drawing.Size(433, 56);
            this.groupBoxTemplateDoubleClick.TabIndex = 0;
            this.groupBoxTemplateDoubleClick.TabStop = false;
            this.groupBoxTemplateDoubleClick.Text = "On Template Node Double Click";
            // 
            // radioButtonExecuteWithLastSettings
            // 
            this.radioButtonExecuteWithLastSettings.AutoSize = true;
            this.radioButtonExecuteWithLastSettings.Location = new System.Drawing.Point(225, 22);
            this.radioButtonExecuteWithLastSettings.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonExecuteWithLastSettings.Name = "radioButtonExecuteWithLastSettings";
            this.radioButtonExecuteWithLastSettings.Size = new System.Drawing.Size(153, 17);
            this.radioButtonExecuteWithLastSettings.TabIndex = 2;
            this.radioButtonExecuteWithLastSettings.Text = "Execute With Last Settings";
            this.radioButtonExecuteWithLastSettings.UseVisualStyleBackColor = true;
            // 
            // radioButtonExecute
            // 
            this.radioButtonExecute.AutoSize = true;
            this.radioButtonExecute.Checked = true;
            this.radioButtonExecute.Location = new System.Drawing.Point(122, 22);
            this.radioButtonExecute.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonExecute.Name = "radioButtonExecute";
            this.radioButtonExecute.Size = new System.Drawing.Size(64, 17);
            this.radioButtonExecute.TabIndex = 1;
            this.radioButtonExecute.TabStop = true;
            this.radioButtonExecute.Text = "Execute";
            this.radioButtonExecute.UseVisualStyleBackColor = true;
            // 
            // radioButtonEditTemplate
            // 
            this.radioButtonEditTemplate.AutoSize = true;
            this.radioButtonEditTemplate.Location = new System.Drawing.Point(39, 22);
            this.radioButtonEditTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEditTemplate.Name = "radioButtonEditTemplate";
            this.radioButtonEditTemplate.Size = new System.Drawing.Size(43, 17);
            this.radioButtonEditTemplate.TabIndex = 0;
            this.radioButtonEditTemplate.Text = "Edit";
            this.radioButtonEditTemplate.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseNullableTypes
            // 
            this.checkBoxUseNullableTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseNullableTypes.AutoSize = true;
            this.checkBoxUseNullableTypes.Location = new System.Drawing.Point(3, 63);
            this.checkBoxUseNullableTypes.Name = "checkBoxUseNullableTypes";
            this.checkBoxUseNullableTypes.Size = new System.Drawing.Size(431, 17);
            this.checkBoxUseNullableTypes.TabIndex = 1;
            this.checkBoxUseNullableTypes.Text = "Always use Nullable types";
            this.tooltipPrefix.SetToolTip(this.checkBoxUseNullableTypes, "We strongly recommend that you leave this as checked.");
            this.checkBoxUseNullableTypes.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoDatesInHeader
            // 
            this.checkBoxNoDatesInHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxNoDatesInHeader.AutoSize = true;
            this.checkBoxNoDatesInHeader.Location = new System.Drawing.Point(3, 86);
            this.checkBoxNoDatesInHeader.Name = "checkBoxNoDatesInHeader";
            this.checkBoxNoDatesInHeader.Size = new System.Drawing.Size(431, 17);
            this.checkBoxNoDatesInHeader.TabIndex = 2;
            this.checkBoxNoDatesInHeader.Text = "Turn off DateTime in class headers";
            this.checkBoxNoDatesInHeader.UseVisualStyleBackColor = true;
            // 
            // tooltipPrefix
            // 
            this.tooltipPrefix.IsBalloon = true;
            this.tooltipPrefix.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tooltipPrefix.ToolTipTitle = "Warning";
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.toolStripSettings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(451, 524);
            this.Load += new System.EventHandler(this.ucSettings_Load);
            this.Leave += new System.EventHandler(this.ucSettings_Leave);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            this.toolStripSettings.ResumeLayout(false);
            this.toolStripSettings.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPageLocations.ResumeLayout(false);
            this.tableLayoutPanelLocations.ResumeLayout(false);
            this.tableLayoutPanelLocations.PerformLayout();
            this.tabPageNaming.ResumeLayout(false);
            this.tabControlNaming.ResumeLayout(false);
            this.tabPageClass.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageSP.ResumeLayout(false);
            this.tabPageHierarchical.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPageMisc.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageFields.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel28.ResumeLayout(false);
            this.tableLayoutPanel28.PerformLayout();
            this.tabPageOther.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBoxTemplateDoubleClick.ResumeLayout(false);
            this.groupBoxTemplateDoubleClick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetDefault;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TabPage tabPageLocations;
        private System.Windows.Forms.TabPage tabPageNaming;
        private System.Windows.Forms.Button buttonOleDB;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLocations;
        private System.Windows.Forms.Button buttonTemplatePath;
        private System.Windows.Forms.Button buttonOutputPath;
        private System.Windows.Forms.Button buttonLanguageMap;
        private System.Windows.Forms.TextBox textBoxTemplatePath;
        private System.Windows.Forms.TextBox textBoxOutputPath;
        private System.Windows.Forms.TextBox textBoxLanguageMap;
        private System.Windows.Forms.Button buttonUserMetadata;
        private System.Windows.Forms.TextBox textBoxUserMetadata;
        private System.Windows.Forms.TabControl tabControlNaming;
        private System.Windows.Forms.TabPage tabPageClass;
        private System.Windows.Forms.TabPage tabPageSP;
        private System.Windows.Forms.TabPage tabPageHierarchical;
        private System.Windows.Forms.TabPage tabPageMisc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxAbstractPrefix;
        private System.Windows.Forms.TextBox textBoxEntitySuffix;
        private System.Windows.Forms.TextBox textBoxCollectionSuffix;
        private System.Windows.Forms.TextBox textBoxQuerySuffix;
        private System.Windows.Forms.TextBox textBoxMetadataSuffix;
        private System.Windows.Forms.TextBox textBoxProxyStubSuffix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxUseRawNames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textBoxUIAssemblyPath;
        private System.Windows.Forms.Button buttonUIAssemblyPath;
        private System.Windows.Forms.ToolStripButton toolStripButtonReloadDefault;
        private System.Windows.Forms.TextBox textBoxProcPrefix;
        private System.Windows.Forms.TextBox textBoxProcInsert;
        private System.Windows.Forms.TextBox textBoxProcUpdate;
        private System.Windows.Forms.TextBox textBoxProcDelete;
        private System.Windows.Forms.TextBox textBoxProcLoadAll;
        private System.Windows.Forms.TextBox textBoxProcLoadByPK;
        private System.Windows.Forms.TextBox textBoxProcSuffix;
        private System.Windows.Forms.CheckBox checkBoxProcVerbFirst;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelHierPrefix;
        private System.Windows.Forms.Label labelHierSuffix;
        private System.Windows.Forms.Label labelHierSeparator;
        private System.Windows.Forms.TextBox textBoxOnePrefix;
        private System.Windows.Forms.TextBox textBoxOneSuffix;
        private System.Windows.Forms.TextBox textBoxOneSeparator;
        private System.Windows.Forms.TextBox textBoxManyPrefix;
        private System.Windows.Forms.TextBox textBoxManySuffix;
        private System.Windows.Forms.TextBox textBoxManySeparator;
        private System.Windows.Forms.CheckBox checkBoxSelfOnly;
        private System.Windows.Forms.CheckBox checkBoxSwapNames;
        private System.Windows.Forms.CheckBox checkBoxUseAssociativeName;
        private System.Windows.Forms.CheckBox checkBoxUseUpToPrefix;
        private System.Windows.Forms.TextBox textBoxCompilerAssemblyPath;
        private System.Windows.Forms.Button buttonCompilerAssemblyPath;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.TextBox textBoxConnectionHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelProcSample;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonButtonMRU;
        private System.Windows.Forms.ContextMenuStrip menuMRU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSample;
        private System.Windows.Forms.Label labelHierSample;
        private System.Windows.Forms.Label labelHierTypes;
        private System.Windows.Forms.TabPage tabPageOther;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox checkBoxUseNullableTypes;
        private System.Windows.Forms.CheckBox checkBoxNoDatesInHeader;
        private System.Windows.Forms.GroupBox groupBoxTemplateDoubleClick;
        private System.Windows.Forms.RadioButton radioButtonExecuteWithLastSettings;
        private System.Windows.Forms.RadioButton radioButtonExecute;
        private System.Windows.Forms.RadioButton radioButtonEditTemplate;
        private System.Windows.Forms.CheckBox checkBoxPreserveUnderscores;
        private System.Windows.Forms.Label labelHierEntity;
        private System.Windows.Forms.Label labelHierCollection;
        private System.Windows.Forms.Label labelHierTable1;
        private System.Windows.Forms.Label labelHierTable2;
        private System.Windows.Forms.Label labelHierColumn1;
        private System.Windows.Forms.Label labelHierColumn2;
        private System.Windows.Forms.CheckBox checkboxPrefixWithSchema;
        private System.Windows.Forms.ToolTip tooltipPrefix;
        private System.Windows.Forms.TabPage tabPageFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label lblSelectedDriver;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.CheckBox chkDateAddedEnabled;
        private System.Windows.Forms.CheckBox chkDateAddedServerSideEnabled;
        private System.Windows.Forms.TextBox txtDateAddedServerSideText;
        private System.Windows.Forms.CheckBox chkDateAddedClientSideEnabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.RadioButton rdoDateAddedClientSideUtcNow;
        private System.Windows.Forms.RadioButton rdoDateAddedClientSideNow;
        private System.Windows.Forms.TextBox txtDateAddedColumnName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.CheckBox chkDateModifiedEnabled;
        private System.Windows.Forms.CheckBox chkDateModifiedServerSideEnabled;
        private System.Windows.Forms.TextBox txtDateModifiedServerSideText;
        private System.Windows.Forms.CheckBox chkDateModifiedClientSideEnabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.RadioButton rdoDateModifiedClientSideUtcNow;
        private System.Windows.Forms.RadioButton rdoDateModifiedClientSideNow;
        private System.Windows.Forms.TextBox txtDateModifiedColumnName;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.CheckBox chkAddedByEnabled;
        private System.Windows.Forms.TextBox txtAddedByColumnName;
        private System.Windows.Forms.TextBox txtAddedByServerSideText;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.CheckBox chkModifiedByEnabled;
        private System.Windows.Forms.TextBox txtModifiedByColumnName;
        private System.Windows.Forms.TextBox txtModifiedByServerSideText;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private System.Windows.Forms.TextBox txtConcurrencyColumnName;
        private System.Windows.Forms.CheckBox chkAddedByServerSide;
        private System.Windows.Forms.CheckBox chkAddedByEventHandler;
        private System.Windows.Forms.CheckBox chkModifiedByServerSide;
        private System.Windows.Forms.CheckBox chkModifiedByEventHandler;
        private System.Windows.Forms.CheckBox chkConcurrencyColumn;


    }
}
