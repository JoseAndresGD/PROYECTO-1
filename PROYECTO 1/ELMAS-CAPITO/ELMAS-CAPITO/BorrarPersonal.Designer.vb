'
' Created by SharpDevelop.
' User: S1015
' Date: 28/03/2023
' Time: 01:55 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class BorrarPersonal
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
		Me.BorrarIdPersonal = New System.Windows.Forms.TextBox()
		Me.btnBorrar = New System.Windows.Forms.Button()
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
		Me.label1.Text = "Id del Personal:"
		'
		'BorrarIdPersonal
		'
		Me.BorrarIdPersonal.Location = New System.Drawing.Point(119, 10)
		Me.BorrarIdPersonal.Name = "BorrarIdPersonal"
		Me.BorrarIdPersonal.Size = New System.Drawing.Size(123, 20)
		Me.BorrarIdPersonal.TabIndex = 2
		AddHandler Me.BorrarIdPersonal.TextChanged, AddressOf Me.BorrarIdPersonalTextChanged
		'
		'btnBorrar
		'
		Me.btnBorrar.Location = New System.Drawing.Point(281, 10)
		Me.btnBorrar.Name = "btnBorrar"
		Me.btnBorrar.Size = New System.Drawing.Size(120, 20)
		Me.btnBorrar.TabIndex = 3
		Me.btnBorrar.Text = "BORRAR"
		Me.btnBorrar.UseVisualStyleBackColor = true
		AddHandler Me.btnBorrar.Click, AddressOf Me.BtnBorrarClick
		'
		'BorrarPersonal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1042, 261)
		Me.Controls.Add(Me.btnBorrar)
		Me.Controls.Add(Me.BorrarIdPersonal)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "BorrarPersonal"
		Me.Text = "BorrarPersonal"
		AddHandler Load, AddressOf Me.BorrarPersonalLoad
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnBorrar As System.Windows.Forms.Button
	Private BorrarIdPersonal As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private dgvDatos As System.Windows.Forms.DataGridView
End Class
