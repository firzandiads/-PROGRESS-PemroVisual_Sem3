﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim NIMLabel As System.Windows.Forms.Label
        Dim NAMALabel As System.Windows.Forms.Label
        Dim ALAMATLabel As System.Windows.Forms.Label
        Dim TELPLabel As System.Windows.Forms.Label
        Dim KELAMINLabel As System.Windows.Forms.Label
        Me.Prak_11_AccessDataSet = New Prak_11._2.Prak_11_AccessDataSet
        Me.MHSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MHSTableAdapter = New Prak_11._2.Prak_11_AccessDataSetTableAdapters.MHSTableAdapter
        Me.TableAdapterManager = New Prak_11._2.Prak_11_AccessDataSetTableAdapters.TableAdapterManager
        Me.MHSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.MHSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MHSDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NIMTextBox = New System.Windows.Forms.TextBox
        Me.NAMATextBox = New System.Windows.Forms.TextBox
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox
        Me.TELPTextBox = New System.Windows.Forms.TextBox
        Me.KELAMINTextBox = New System.Windows.Forms.TextBox
        NIMLabel = New System.Windows.Forms.Label
        NAMALabel = New System.Windows.Forms.Label
        ALAMATLabel = New System.Windows.Forms.Label
        TELPLabel = New System.Windows.Forms.Label
        KELAMINLabel = New System.Windows.Forms.Label
        CType(Me.Prak_11_AccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MHSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MHSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MHSBindingNavigator.SuspendLayout()
        CType(Me.MHSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Prak_11_AccessDataSet
        '
        Me.Prak_11_AccessDataSet.DataSetName = "Prak_11_AccessDataSet"
        Me.Prak_11_AccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MHSBindingSource
        '
        Me.MHSBindingSource.DataMember = "MHS"
        Me.MHSBindingSource.DataSource = Me.Prak_11_AccessDataSet
        '
        'MHSTableAdapter
        '
        Me.MHSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MHSTableAdapter = Me.MHSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Prak_11._2.Prak_11_AccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MHSBindingNavigator
        '
        Me.MHSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MHSBindingNavigator.BindingSource = Me.MHSBindingSource
        Me.MHSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MHSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MHSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MHSBindingNavigatorSaveItem})
        Me.MHSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MHSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MHSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MHSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MHSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MHSBindingNavigator.Name = "MHSBindingNavigator"
        Me.MHSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MHSBindingNavigator.Size = New System.Drawing.Size(514, 25)
        Me.MHSBindingNavigator.TabIndex = 0
        Me.MHSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MHSBindingNavigatorSaveItem
        '
        Me.MHSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MHSBindingNavigatorSaveItem.Image = CType(resources.GetObject("MHSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MHSBindingNavigatorSaveItem.Name = "MHSBindingNavigatorSaveItem"
        Me.MHSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MHSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MHSDataGridView
        '
        Me.MHSDataGridView.AutoGenerateColumns = False
        Me.MHSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MHSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MHSDataGridView.DataSource = Me.MHSBindingSource
        Me.MHSDataGridView.Location = New System.Drawing.Point(12, 208)
        Me.MHSDataGridView.Name = "MHSDataGridView"
        Me.MHSDataGridView.Size = New System.Drawing.Size(467, 82)
        Me.MHSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NIM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NIM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NAMA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NAMA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ALAMAT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ALAMAT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TELP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TELP"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KELAMIN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "KELAMIN"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'NIMLabel
        '
        NIMLabel.AutoSize = True
        NIMLabel.Location = New System.Drawing.Point(40, 43)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New System.Drawing.Size(30, 13)
        NIMLabel.TabIndex = 2
        NIMLabel.Text = "NIM:"
        '
        'NIMTextBox
        '
        Me.NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MHSBindingSource, "NIM", True))
        Me.NIMTextBox.Location = New System.Drawing.Point(76, 40)
        Me.NIMTextBox.Name = "NIMTextBox"
        Me.NIMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIMTextBox.TabIndex = 3
        '
        'NAMALabel
        '
        NAMALabel.AutoSize = True
        NAMALabel.Location = New System.Drawing.Point(29, 69)
        NAMALabel.Name = "NAMALabel"
        NAMALabel.Size = New System.Drawing.Size(41, 13)
        NAMALabel.TabIndex = 4
        NAMALabel.Text = "NAMA:"
        '
        'NAMATextBox
        '
        Me.NAMATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MHSBindingSource, "NAMA", True))
        Me.NAMATextBox.Location = New System.Drawing.Point(76, 66)
        Me.NAMATextBox.Name = "NAMATextBox"
        Me.NAMATextBox.Size = New System.Drawing.Size(259, 20)
        Me.NAMATextBox.TabIndex = 5
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.Location = New System.Drawing.Point(17, 99)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(53, 13)
        ALAMATLabel.TabIndex = 6
        ALAMATLabel.Text = "ALAMAT:"
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MHSBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Location = New System.Drawing.Point(76, 96)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(333, 20)
        Me.ALAMATTextBox.TabIndex = 7
        '
        'TELPLabel
        '
        TELPLabel.AutoSize = True
        TELPLabel.Location = New System.Drawing.Point(33, 125)
        TELPLabel.Name = "TELPLabel"
        TELPLabel.Size = New System.Drawing.Size(37, 13)
        TELPLabel.TabIndex = 8
        TELPLabel.Text = "TELP:"
        '
        'TELPTextBox
        '
        Me.TELPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MHSBindingSource, "TELP", True))
        Me.TELPTextBox.Location = New System.Drawing.Point(76, 122)
        Me.TELPTextBox.Name = "TELPTextBox"
        Me.TELPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TELPTextBox.TabIndex = 9
        '
        'KELAMINLabel
        '
        KELAMINLabel.AutoSize = True
        KELAMINLabel.Location = New System.Drawing.Point(13, 160)
        KELAMINLabel.Name = "KELAMINLabel"
        KELAMINLabel.Size = New System.Drawing.Size(57, 13)
        KELAMINLabel.TabIndex = 10
        KELAMINLabel.Text = "KELAMIN:"
        '
        'KELAMINTextBox
        '
        Me.KELAMINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MHSBindingSource, "KELAMIN", True))
        Me.KELAMINTextBox.Location = New System.Drawing.Point(76, 157)
        Me.KELAMINTextBox.Name = "KELAMINTextBox"
        Me.KELAMINTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KELAMINTextBox.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 310)
        Me.Controls.Add(KELAMINLabel)
        Me.Controls.Add(Me.KELAMINTextBox)
        Me.Controls.Add(TELPLabel)
        Me.Controls.Add(Me.TELPTextBox)
        Me.Controls.Add(ALAMATLabel)
        Me.Controls.Add(Me.ALAMATTextBox)
        Me.Controls.Add(NAMALabel)
        Me.Controls.Add(Me.NAMATextBox)
        Me.Controls.Add(NIMLabel)
        Me.Controls.Add(Me.NIMTextBox)
        Me.Controls.Add(Me.MHSDataGridView)
        Me.Controls.Add(Me.MHSBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Prak_11_AccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MHSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MHSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MHSBindingNavigator.ResumeLayout(False)
        Me.MHSBindingNavigator.PerformLayout()
        CType(Me.MHSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Prak_11_AccessDataSet As Prak_11._2.Prak_11_AccessDataSet
    Friend WithEvents MHSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MHSTableAdapter As Prak_11._2.Prak_11_AccessDataSetTableAdapters.MHSTableAdapter
    Friend WithEvents TableAdapterManager As Prak_11._2.Prak_11_AccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MHSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MHSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MHSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TELPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KELAMINTextBox As System.Windows.Forms.TextBox

End Class
