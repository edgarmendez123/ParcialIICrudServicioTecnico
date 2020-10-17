<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet = New ProyectoparcialII.clientesDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.bt_Insetar = New System.Windows.Forms.Button()
        Me.Bt_modificar = New System.Windows.Forms.Button()
        Me.Bt_borrar = New System.Windows.Forms.Button()
        Me.Bt_Salir = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New ProyectoparcialII.clientesDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New ProyectoparcialII.clientesDataSetTableAdapters.TableAdapterManager()
        Me.Bt_Nuevo = New System.Windows.Forms.Button()
        Me.Bt_Guardar = New System.Windows.Forms.Button()
        Me.Bt_buscar = New System.Windows.Forms.Button()
        Me.Bt_Actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(78, 81)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(50, 13)
        IdclienteLabel.TabIndex = 2
        IdclienteLabel.Text = "Idcliente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(83, 115)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(305, 77)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 6
        ApellidoLabel.Text = "apellido:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(311, 118)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(40, 13)
        CorreoLabel.TabIndex = 8
        CorreoLabel.Text = "correo:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(519, 73)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(514, 121)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 12
        DireccionLabel.Text = "direccion:"
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(743, 25)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
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
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ClientesDataSet
        '
        'ClientesDataSet
        '
        Me.ClientesDataSet.DataSetName = "clientesDataSet"
        Me.ClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(81, 291)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(618, 150)
        Me.ClientesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idcliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idcliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "correo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(134, 78)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdclienteTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(134, 112)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(357, 74)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 7
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(357, 115)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CorreoTextBox.TabIndex = 9
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(573, 70)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 11
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(573, 118)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 13
        '
        'bt_Insetar
        '
        Me.bt_Insetar.Image = CType(resources.GetObject("bt_Insetar.Image"), System.Drawing.Image)
        Me.bt_Insetar.Location = New System.Drawing.Point(134, 162)
        Me.bt_Insetar.Name = "bt_Insetar"
        Me.bt_Insetar.Size = New System.Drawing.Size(92, 52)
        Me.bt_Insetar.TabIndex = 14
        Me.bt_Insetar.Text = "Insertar"
        Me.bt_Insetar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Insetar.UseVisualStyleBackColor = True
        '
        'Bt_modificar
        '
        Me.Bt_modificar.Image = CType(resources.GetObject("Bt_modificar.Image"), System.Drawing.Image)
        Me.Bt_modificar.Location = New System.Drawing.Point(404, 165)
        Me.Bt_modificar.Name = "Bt_modificar"
        Me.Bt_modificar.Size = New System.Drawing.Size(92, 52)
        Me.Bt_modificar.TabIndex = 15
        Me.Bt_modificar.Text = "Modificar"
        Me.Bt_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_modificar.UseVisualStyleBackColor = True
        '
        'Bt_borrar
        '
        Me.Bt_borrar.Image = CType(resources.GetObject("Bt_borrar.Image"), System.Drawing.Image)
        Me.Bt_borrar.Location = New System.Drawing.Point(134, 232)
        Me.Bt_borrar.Name = "Bt_borrar"
        Me.Bt_borrar.Size = New System.Drawing.Size(92, 52)
        Me.Bt_borrar.TabIndex = 16
        Me.Bt_borrar.Text = "Borrar"
        Me.Bt_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_borrar.UseVisualStyleBackColor = True
        '
        'Bt_Salir
        '
        Me.Bt_Salir.Image = CType(resources.GetObject("Bt_Salir.Image"), System.Drawing.Image)
        Me.Bt_Salir.Location = New System.Drawing.Point(404, 236)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(92, 48)
        Me.Bt_Salir.TabIndex = 17
        Me.Bt_Salir.Text = "Salir"
        Me.Bt_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_Salir.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoparcialII.clientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Bt_Nuevo
        '
        Me.Bt_Nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bt_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.Bt_Nuevo.Image = CType(resources.GetObject("Bt_Nuevo.Image"), System.Drawing.Image)
        Me.Bt_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_Nuevo.Location = New System.Drawing.Point(272, 232)
        Me.Bt_Nuevo.Name = "Bt_Nuevo"
        Me.Bt_Nuevo.Size = New System.Drawing.Size(89, 52)
        Me.Bt_Nuevo.TabIndex = 18
        Me.Bt_Nuevo.Text = "Nuevo"
        Me.Bt_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_Nuevo.UseVisualStyleBackColor = False
        '
        'Bt_Guardar
        '
        Me.Bt_Guardar.Image = CType(resources.GetObject("Bt_Guardar.Image"), System.Drawing.Image)
        Me.Bt_Guardar.Location = New System.Drawing.Point(272, 162)
        Me.Bt_Guardar.Name = "Bt_Guardar"
        Me.Bt_Guardar.Size = New System.Drawing.Size(98, 52)
        Me.Bt_Guardar.TabIndex = 19
        Me.Bt_Guardar.Text = "Guardar"
        Me.Bt_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_Guardar.UseVisualStyleBackColor = True
        '
        'Bt_buscar
        '
        Me.Bt_buscar.Image = CType(resources.GetObject("Bt_buscar.Image"), System.Drawing.Image)
        Me.Bt_buscar.Location = New System.Drawing.Point(536, 165)
        Me.Bt_buscar.Name = "Bt_buscar"
        Me.Bt_buscar.Size = New System.Drawing.Size(101, 49)
        Me.Bt_buscar.TabIndex = 20
        Me.Bt_buscar.Text = "Buscar "
        Me.Bt_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_buscar.UseVisualStyleBackColor = True
        '
        'Bt_Actualizar
        '
        Me.Bt_Actualizar.Image = CType(resources.GetObject("Bt_Actualizar.Image"), System.Drawing.Image)
        Me.Bt_Actualizar.Location = New System.Drawing.Point(545, 232)
        Me.Bt_Actualizar.Name = "Bt_Actualizar"
        Me.Bt_Actualizar.Size = New System.Drawing.Size(92, 52)
        Me.Bt_Actualizar.TabIndex = 21
        Me.Bt_Actualizar.Text = "Actualizar"
        Me.Bt_Actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_Actualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 27)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "REGISTRO DE CLIENTES"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(743, 446)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_Actualizar)
        Me.Controls.Add(Me.Bt_buscar)
        Me.Controls.Add(Me.Bt_Guardar)
        Me.Controls.Add(Me.Bt_Nuevo)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_borrar)
        Me.Controls.Add(Me.Bt_modificar)
        Me.Controls.Add(Me.bt_Insetar)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(IdclienteLabel)
        Me.Controls.Add(Me.IdclienteTextBox)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Name = "Clientes"
        Me.Text = "Form2"
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientesDataSet As ProyectoparcialII.clientesDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoparcialII.clientesDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoparcialII.clientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bt_Insetar As System.Windows.Forms.Button
    Friend WithEvents Bt_modificar As System.Windows.Forms.Button
    Friend WithEvents Bt_borrar As System.Windows.Forms.Button
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Bt_Nuevo As System.Windows.Forms.Button
    Friend WithEvents Bt_Guardar As System.Windows.Forms.Button
    Friend WithEvents Bt_buscar As System.Windows.Forms.Button
    Friend WithEvents Bt_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
