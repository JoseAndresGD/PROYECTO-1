'
' Created by SharpDevelop.
' User: S1015
' Date: 27/03/2023
' Time: 11:00 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class BuscarPersonal
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
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.idpersonalBuscar = New System.Windows.Forms.TextBox()
		Me.nombrebuscar = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.apellidopBuscar = New System.Windows.Forms.TextBox()
		Me.btnFiltrar = New System.Windows.Forms.Button()
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dgvDatos
		'
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(12, 99)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.Size = New System.Drawing.Size(1018, 150)
		Me.dgvDatos.TabIndex = 0
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(13, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Id del personal:"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(13, 52)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Nombre: "
		'
		'idpersonalBuscar
		'
		Me.idpersonalBuscar.Location = New System.Drawing.Point(119, 10)
		Me.idpersonalBuscar.Name = "idpersonalBuscar"
		Me.idpersonalBuscar.Size = New System.Drawing.Size(154, 20)
		Me.idpersonalBuscar.TabIndex = 3
		AddHandler Me.idpersonalBuscar.TextChanged, AddressOf Me.IdpersonalBuscarTextChanged
		'
		'nombrebuscar
		'
		Me.nombrebuscar.Location = New System.Drawing.Point(119, 49)
		Me.nombrebuscar.Name = "nombrebuscar"
		Me.nombrebuscar.Size = New System.Drawing.Size(154, 20)
		Me.nombrebuscar.TabIndex = 4
		AddHandler Me.nombrebuscar.TextChanged, AddressOf Me.NombrebuscarTextChanged
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(299, 52)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(108, 17)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Apellido Paterno:"
		'
		'apellidopBuscar
		'
		Me.apellidopBuscar.Location = New System.Drawing.Point(413, 49)
		Me.apellidopBuscar.Name = "apellidopBuscar"
		Me.apellidopBuscar.Size = New System.Drawing.Size(154, 20)
		Me.apellidopBuscar.TabIndex = 6
		'
		'btnFiltrar
		'
		Me.btnFiltrar.Location = New System.Drawing.Point(592, 47)
		Me.btnFiltrar.Name = "btnFiltrar"
		Me.btnFiltrar.Size = New System.Drawing.Size(101, 23)
		Me.btnFiltrar.TabIndex = 7
		Me.btnFiltrar.Text = "FILTRAR"
		Me.btnFiltrar.UseVisualStyleBackColor = true
		AddHandler Me.btnFiltrar.Click, AddressOf Me.BtnFiltrarClick
		'
		'BuscarPersonal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1042, 261)
		Me.Controls.Add(Me.btnFiltrar)
		Me.Controls.Add(Me.apellidopBuscar)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.nombrebuscar)
		Me.Controls.Add(Me.idpersonalBuscar)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "BuscarPersonal"
		Me.Text = "BuscarPersonal"
		AddHandler Load, AddressOf Me.BuscarPersonalLoad
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnFiltrar As System.Windows.Forms.Button
	Private apellidopBuscar As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private nombrebuscar As System.Windows.Forms.TextBox
	Private idpersonalBuscar As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private dgvDatos As System.Windows.Forms.DataGridView
End Class
