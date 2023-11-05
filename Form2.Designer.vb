<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblRutCliente = New Label()
        lblTelefono = New Label()
        txtRutCliente = New TextBox()
        txtTelefono = New TextBox()
        btnAgregar = New Button()
        btnMostrarTelefonos = New Button()
        tboxTelefonos = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblRutCliente
        ' 
        lblRutCliente.AutoSize = True
        lblRutCliente.Location = New Point(10, 32)
        lblRutCliente.Name = "lblRutCliente"
        lblRutCliente.Size = New Size(65, 15)
        lblRutCliente.TabIndex = 0
        lblRutCliente.Text = "Rut Cliente"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(23, 70)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(52, 15)
        lblTelefono.TabIndex = 1
        lblTelefono.Text = "Telefono"
        ' 
        ' txtRutCliente
        ' 
        txtRutCliente.Location = New Point(105, 29)
        txtRutCliente.Name = "txtRutCliente"
        txtRutCliente.Size = New Size(137, 23)
        txtRutCliente.TabIndex = 2
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(105, 67)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(137, 23)
        txtTelefono.TabIndex = 3
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnAgregar.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnAgregar.Location = New Point(10, 105)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(104, 36)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnMostrarTelefonos
        ' 
        btnMostrarTelefonos.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnMostrarTelefonos.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnMostrarTelefonos.Location = New Point(140, 105)
        btnMostrarTelefonos.Name = "btnMostrarTelefonos"
        btnMostrarTelefonos.Size = New Size(107, 36)
        btnMostrarTelefonos.TabIndex = 5
        btnMostrarTelefonos.Text = "Mostrar"
        btnMostrarTelefonos.UseVisualStyleBackColor = False
        ' 
        ' tboxTelefonos
        ' 
        tboxTelefonos.Location = New Point(12, 147)
        tboxTelefonos.Multiline = True
        tboxTelefonos.Name = "tboxTelefonos"
        tboxTelefonos.ReadOnly = True
        tboxTelefonos.ScrollBars = ScrollBars.Vertical
        tboxTelefonos.Size = New Size(235, 173)
        tboxTelefonos.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.AppWorkspace
        Label1.Location = New Point(105, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 15)
        Label1.TabIndex = 7
        Label1.Text = "(Rut de cliente existente)"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(258, 332)
        Controls.Add(Label1)
        Controls.Add(tboxTelefonos)
        Controls.Add(btnMostrarTelefonos)
        Controls.Add(btnAgregar)
        Controls.Add(txtTelefono)
        Controls.Add(txtRutCliente)
        Controls.Add(lblTelefono)
        Controls.Add(lblRutCliente)
        Name = "Form2"
        Text = "Agregar Telefono"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRutCliente As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtRutCliente As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnMostrarTelefonos As Button
    Friend WithEvents tboxTelefonos As TextBox
    Friend WithEvents Label1 As Label
End Class
