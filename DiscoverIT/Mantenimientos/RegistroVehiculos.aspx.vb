﻿Imports BusinessEntity
Imports System.IO
Public Class RegistroVehiculos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

        End If
    End Sub

    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGrabar.Click
        Dim objVehiculo As New VehiculoBE
        With objVehiculo
            .Placa = txtNroPlaca.Text
            .Marca = lblMarca.Text
            .Modelo = lblModelo.Text
            .Propietario = lblPropietario.Text
            .Sede = lblSede.Text
            .Descripcion = txtDescripcion.Text
            .Kilometraje = txtKilometraje.Text
            .Motor = txtMotor.Text
            .Transmision = txtTransmision.Text
            .Combustible = txtCombustible.Text
            .Imagen = hidImagen.Value
        End With
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click

    End Sub

    Protected Sub btnCargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCargar.Click
        If (fuImagen.HasFile) Then
            Dim savePath As String = "C:\Users\Diegop\Documents\Visual Studio 2010\Projects\DiscoverIT\DiscoverIT\Vehiculos\"
            Dim fileName As String = fuImagen.FileName

            savePath += fileName
            fuImagen.SaveAs(savePath)

            imgVehiculo.ImageUrl = "~/Vehiculos/" + fileName
            hidImagen.Value = fileName
        End If
    End Sub
End Class