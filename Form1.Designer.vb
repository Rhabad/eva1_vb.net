<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblRut = New Label()
        lblNombre = New Label()
        lblApellido = New Label()
        lblCorreo = New Label()
        lblDireccion = New Label()
        lbTitulo = New Label()
        txtRut = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtCorreo = New TextBox()
        lblEdad = New Label()
        lblGenero = New Label()
        txtDireccion = New TextBox()
        numEdad = New NumericUpDown()
        btnAceptar = New Button()
        tbox = New TextBox()
        btnMostrar = New Button()
        Combo1 = New ComboBox()
        btnAgregarTelefono = New Button()
        CType(numEdad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblRut
        ' 
        lblRut.AutoSize = True
        lblRut.Location = New Point(72, 127)
        lblRut.Name = "lblRut"
        lblRut.Size = New Size(25, 15)
        lblRut.TabIndex = 0
        lblRut.Text = "Rut"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(46, 157)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(51, 15)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(46, 187)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(51, 15)
        lblApellido.TabIndex = 2
        lblApellido.Text = "Apellido"
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(45, 277)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(43, 15)
        lblCorreo.TabIndex = 3
        lblCorreo.Text = "Correo"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(40, 307)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(57, 15)
        lblDireccion.TabIndex = 4
        lblDireccion.Text = "Direccion"
        ' 
        ' lbTitulo
        ' 
        lbTitulo.AutoSize = True
        lbTitulo.Font = New Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point)
        lbTitulo.ForeColor = Color.Lime
        lbTitulo.Location = New Point(146, 44)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(304, 30)
        lbTitulo.TabIndex = 6
        lbTitulo.Text = "Registro De Empleados"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(116, 119)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(142, 23)
        txtRut.TabIndex = 7
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(116, 154)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(142, 23)
        txtNombre.TabIndex = 8
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(116, 183)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(142, 23)
        txtApellido.TabIndex = 9
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(116, 277)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(142, 23)
        txtCorreo.TabIndex = 11
        ' 
        ' lblEdad
        ' 
        lblEdad.AutoSize = True
        lblEdad.Location = New Point(64, 217)
        lblEdad.Name = "lblEdad"
        lblEdad.Size = New Size(33, 15)
        lblEdad.TabIndex = 12
        lblEdad.Text = "Edad"
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.Location = New Point(52, 247)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(45, 15)
        lblGenero.TabIndex = 13
        lblGenero.Text = "Genero"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(116, 307)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(142, 23)
        txtDireccion.TabIndex = 14
        ' 
        ' numEdad
        ' 
        numEdad.Location = New Point(116, 215)
        numEdad.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        numEdad.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        numEdad.Name = "numEdad"
        numEdad.Size = New Size(39, 23)
        numEdad.TabIndex = 17
        numEdad.Value = New Decimal(New Integer() {18, 0, 0, 0})
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnAceptar.ForeColor = Color.Yellow
        btnAceptar.Location = New Point(46, 346)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(85, 65)
        btnAceptar.TabIndex = 18
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' tbox
        ' 
        tbox.Location = New Point(298, 107)
        tbox.Multiline = True
        tbox.Name = "tbox"
        tbox.ReadOnly = True
        tbox.ScrollBars = ScrollBars.Vertical
        tbox.Size = New Size(261, 272)
        tbox.TabIndex = 19
        ' 
        ' btnMostrar
        ' 
        btnMostrar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnMostrar.ForeColor = Color.Yellow
        btnMostrar.Location = New Point(173, 345)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(85, 66)
        btnMostrar.TabIndex = 21
        btnMostrar.Text = "Mostrar"
        btnMostrar.UseVisualStyleBackColor = False
        ' 
        ' Combo1
        ' 
        Combo1.FormattingEnabled = True
        Combo1.Items.AddRange(New Object() {"Masculino", "Femenino", "NO BINARIE"})
        Combo1.Location = New Point(116, 244)
        Combo1.Name = "Combo1"
        Combo1.Size = New Size(142, 23)
        Combo1.TabIndex = 24
        ' 
        ' btnAgregarTelefono
        ' 
        btnAgregarTelefono.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnAgregarTelefono.ForeColor = Color.Yellow
        btnAgregarTelefono.Location = New Point(321, 385)
        btnAgregarTelefono.Name = "btnAgregarTelefono"
        btnAgregarTelefono.Size = New Size(196, 28)
        btnAgregarTelefono.TabIndex = 25
        btnAgregarTelefono.Text = "Agregar Telefonos"
        btnAgregarTelefono.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(571, 423)
        Controls.Add(btnAgregarTelefono)
        Controls.Add(Combo1)
        Controls.Add(btnMostrar)
        Controls.Add(tbox)
        Controls.Add(btnAceptar)
        Controls.Add(numEdad)
        Controls.Add(txtDireccion)
        Controls.Add(lblGenero)
        Controls.Add(lblEdad)
        Controls.Add(txtCorreo)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtRut)
        Controls.Add(lbTitulo)
        Controls.Add(lblDireccion)
        Controls.Add(lblCorreo)
        Controls.Add(lblApellido)
        Controls.Add(lblNombre)
        Controls.Add(lblRut)
        Name = "Form1"
        Text = "Registro De Empleados"
        CType(numEdad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRut As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lbTitulo As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents numEdad As NumericUpDown
    Friend WithEvents btnAceptar As Button
    Friend WithEvents tbox As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Combo1 As ComboBox
    Friend WithEvents btnAgregarTelefono As Button
End Class
