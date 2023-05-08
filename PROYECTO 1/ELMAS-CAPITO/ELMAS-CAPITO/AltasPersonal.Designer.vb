'
' Created by SharpDevelop.
' User: S1015
' Date: 27/03/2023
' Time: 06:46 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class AltasPersonal
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.txt1 = New System.Windows.Forms.Label()
		Me.txt2 = New System.Windows.Forms.Label()
		Me.txt3 = New System.Windows.Forms.Label()
		Me.txt4 = New System.Windows.Forms.Label()
		Me.txt5 = New System.Windows.Forms.Label()
		Me.txt6 = New System.Windows.Forms.Label()
		Me.txt7 = New System.Windows.Forms.Label()
		Me.txt9 = New System.Windows.Forms.Label()
		Me.txt8 = New System.Windows.Forms.Label()
		Me.idPersonalAltas = New System.Windows.Forms.TextBox()
		Me.nombreAltas = New System.Windows.Forms.TextBox()
		Me.apellidopAltas = New System.Windows.Forms.TextBox()
		Me.apellidomAltas = New System.Windows.Forms.TextBox()
		Me.edadAltas = New System.Windows.Forms.TextBox()
		Me.telefonoAltas = New System.Windows.Forms.TextBox()
		Me.borrarAltas = New System.Windows.Forms.Button()
		Me.agregarAltas = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.rolAltas = New System.Windows.Forms.TextBox()
		Me.sexoAltas = New System.Windows.Forms.ComboBox()
		Me.idDepartamentoAltas = New System.Windows.Forms.ComboBox()
		Me.correoAltas = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'txt1
		'
		Me.txt1.Location = New System.Drawing.Point(12, 9)
		Me.txt1.Name = "txt1"
		Me.txt1.Size = New System.Drawing.Size(100, 20)
		Me.txt1.TabIndex = 0
		Me.txt1.Text = "Id del personal:"
		'
		'txt2
		'
		Me.txt2.Location = New System.Drawing.Point(12, 43)
		Me.txt2.Name = "txt2"
		Me.txt2.Size = New System.Drawing.Size(100, 20)
		Me.txt2.TabIndex = 1
		Me.txt2.Text = "Nombre:"
		'
		'txt3
		'
		Me.txt3.Location = New System.Drawing.Point(12, 78)
		Me.txt3.Name = "txt3"
		Me.txt3.Size = New System.Drawing.Size(100, 23)
		Me.txt3.TabIndex = 2
		Me.txt3.Text = "Apellido Paterno:"
		'
		'txt4
		'
		Me.txt4.Location = New System.Drawing.Point(12, 111)
		Me.txt4.Name = "txt4"
		Me.txt4.Size = New System.Drawing.Size(100, 23)
		Me.txt4.TabIndex = 3
		Me.txt4.Text = "Apellido Materno:"
		'
		'txt5
		'
		Me.txt5.Location = New System.Drawing.Point(12, 146)
		Me.txt5.Name = "txt5"
		Me.txt5.Size = New System.Drawing.Size(100, 23)
		Me.txt5.TabIndex = 4
		Me.txt5.Text = "Sexo:"
		'
		'txt6
		'
		Me.txt6.Location = New System.Drawing.Point(12, 178)
		Me.txt6.Name = "txt6"
		Me.txt6.Size = New System.Drawing.Size(100, 23)
		Me.txt6.TabIndex = 5
		Me.txt6.Text = "Edad:"
		'
		'txt7
		'
		Me.txt7.Location = New System.Drawing.Point(12, 211)
		Me.txt7.Name = "txt7"
		Me.txt7.Size = New System.Drawing.Size(100, 23)
		Me.txt7.TabIndex = 6
		Me.txt7.Text = "Telefono:"
		'
		'txt9
		'
		Me.txt9.Location = New System.Drawing.Point(12, 282)
		Me.txt9.Name = "txt9"
		Me.txt9.Size = New System.Drawing.Size(100, 23)
		Me.txt9.TabIndex = 7
		Me.txt9.Text = "Correo Electronico:"
		'
		'txt8
		'
		Me.txt8.Location = New System.Drawing.Point(12, 244)
		Me.txt8.Name = "txt8"
		Me.txt8.Size = New System.Drawing.Size(113, 23)
		Me.txt8.TabIndex = 8
		Me.txt8.Text = "Id del departamento :"
		'
		'idPersonalAltas
		'
		Me.idPersonalAltas.Location = New System.Drawing.Point(131, 9)
		Me.idPersonalAltas.Name = "idPersonalAltas"
		Me.idPersonalAltas.Size = New System.Drawing.Size(232, 20)
		Me.idPersonalAltas.TabIndex = 9
		'
		'nombreAltas
		'
		Me.nombreAltas.Location = New System.Drawing.Point(131, 43)
		Me.nombreAltas.Name = "nombreAltas"
		Me.nombreAltas.Size = New System.Drawing.Size(232, 20)
		Me.nombreAltas.TabIndex = 10
		'
		'apellidopAltas
		'
		Me.apellidopAltas.Location = New System.Drawing.Point(131, 75)
		Me.apellidopAltas.Name = "apellidopAltas"
		Me.apellidopAltas.Size = New System.Drawing.Size(232, 20)
		Me.apellidopAltas.TabIndex = 11
		'
		'apellidomAltas
		'
		Me.apellidomAltas.Location = New System.Drawing.Point(131, 108)
		Me.apellidomAltas.Name = "apellidomAltas"
		Me.apellidomAltas.Size = New System.Drawing.Size(232, 20)
		Me.apellidomAltas.TabIndex = 12
		'
		'edadAltas
		'
		Me.edadAltas.Location = New System.Drawing.Point(131, 175)
		Me.edadAltas.Name = "edadAltas"
		Me.edadAltas.Size = New System.Drawing.Size(232, 20)
		Me.edadAltas.TabIndex = 14
		'
		'telefonoAltas
		'
		Me.telefonoAltas.Location = New System.Drawing.Point(131, 208)
		Me.telefonoAltas.Name = "telefonoAltas"
		Me.telefonoAltas.Size = New System.Drawing.Size(232, 20)
		Me.telefonoAltas.TabIndex = 15
		'
		'borrarAltas
		'
		Me.borrarAltas.Location = New System.Drawing.Point(91, 373)
		Me.borrarAltas.Name = "borrarAltas"
		Me.borrarAltas.Size = New System.Drawing.Size(80, 25)
		Me.borrarAltas.TabIndex = 18
		Me.borrarAltas.Text = "BORRAR"
		Me.borrarAltas.UseVisualStyleBackColor = true
		AddHandler Me.borrarAltas.Click, AddressOf Me.BorrarAltasClick
		'
		'agregarAltas
		'
		Me.agregarAltas.Location = New System.Drawing.Point(247, 373)
		Me.agregarAltas.Name = "agregarAltas"
		Me.agregarAltas.Size = New System.Drawing.Size(80, 25)
		Me.agregarAltas.TabIndex = 19
		Me.agregarAltas.Text = "AGREGAR"
		Me.agregarAltas.UseVisualStyleBackColor = true
		AddHandler Me.agregarAltas.Click, AddressOf Me.AgregarAltasClick
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 326)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 20
		Me.label1.Text = "Rol"
		'
		'rolAltas
		'
		Me.rolAltas.Location = New System.Drawing.Point(131, 323)
		Me.rolAltas.Name = "rolAltas"
		Me.rolAltas.Size = New System.Drawing.Size(232, 20)
		Me.rolAltas.TabIndex = 21
		'
		'sexoAltas
		'
		Me.sexoAltas.FormattingEnabled = true
		Me.sexoAltas.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
		Me.sexoAltas.Location = New System.Drawing.Point(131, 143)
		Me.sexoAltas.Name = "sexoAltas"
		Me.sexoAltas.Size = New System.Drawing.Size(143, 21)
		Me.sexoAltas.TabIndex = 22
		'
		'idDepartamentoAltas
		'
		Me.idDepartamentoAltas.FormattingEnabled = true
		Me.idDepartamentoAltas.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08"})
		Me.idDepartamentoAltas.Location = New System.Drawing.Point(131, 244)
		Me.idDepartamentoAltas.Name = "idDepartamentoAltas"
		Me.idDepartamentoAltas.Size = New System.Drawing.Size(143, 21)
		Me.idDepartamentoAltas.TabIndex = 23
		'
		'correoAltas
		'
		Me.correoAltas.Location = New System.Drawing.Point(131, 282)
		Me.correoAltas.Name = "correoAltas"
		Me.correoAltas.Size = New System.Drawing.Size(232, 20)
		Me.correoAltas.TabIndex = 24
		'
		'AltasPersonal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(412, 410)
		Me.Controls.Add(Me.correoAltas)
		Me.Controls.Add(Me.idDepartamentoAltas)
		Me.Controls.Add(Me.sexoAltas)
		Me.Controls.Add(Me.rolAltas)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.agregarAltas)
		Me.Controls.Add(Me.borrarAltas)
		Me.Controls.Add(Me.telefonoAltas)
		Me.Controls.Add(Me.edadAltas)
		Me.Controls.Add(Me.apellidomAltas)
		Me.Controls.Add(Me.apellidopAltas)
		Me.Controls.Add(Me.nombreAltas)
		Me.Controls.Add(Me.idPersonalAltas)
		Me.Controls.Add(Me.txt8)
		Me.Controls.Add(Me.txt9)
		Me.Controls.Add(Me.txt7)
		Me.Controls.Add(Me.txt6)
		Me.Controls.Add(Me.txt5)
		Me.Controls.Add(Me.txt4)
		Me.Controls.Add(Me.txt3)
		Me.Controls.Add(Me.txt2)
		Me.Controls.Add(Me.txt1)
		Me.Name = "AltasPersonal"
		Me.Text = "AltasPersonal"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private correoAltas As System.Windows.Forms.TextBox
	Private sexoAltas As System.Windows.Forms.ComboBox
	Private rolAltas As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private agregarAltas As System.Windows.Forms.Button
	Private borrarAltas As System.Windows.Forms.Button
	Private idDepartamentoAltas As System.Windows.Forms.ComboBox
	Private telefonoAltas As System.Windows.Forms.TextBox
	Private edadAltas As System.Windows.Forms.TextBox
	Private apellidomAltas As System.Windows.Forms.TextBox
	Private apellidopAltas As System.Windows.Forms.TextBox
	Private nombreAltas As System.Windows.Forms.TextBox
	Private idPersonalAltas As System.Windows.Forms.TextBox
	Private txt8 As System.Windows.Forms.Label
	Private txt9 As System.Windows.Forms.Label
	Private txt7 As System.Windows.Forms.Label
	Private txt6 As System.Windows.Forms.Label
	Private txt5 As System.Windows.Forms.Label
	Private txt4 As System.Windows.Forms.Label
	Private txt3 As System.Windows.Forms.Label
	Private txt2 As System.Windows.Forms.Label
	Private txt1 As System.Windows.Forms.Label
End Class
