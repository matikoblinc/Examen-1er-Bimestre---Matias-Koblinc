using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;

    public float precio1;
    public float precio2;
    public float precio3;

    public float cantidadUnidades1;
    public float cantidadUnidades2;
    public float cantidadUnidades3;

    float descuento1;
    float descuento2;
    float descuento3;

    float precioTodos1;
    float precioTodos2;
    float precioTodos3;

    float montoTotal;
    float descuentoTotal;
    float totalMasDescuentos;

    void Start()
    {
        precioTodos1 = precio1 * cantidadUnidades1;
        precioTodos2 = precio2 * cantidadUnidades2;
        precioTodos3 = precio3 * cantidadUnidades3;

        montoTotal = precioTodos1 + precioTodos2 + precioTodos3;

        if (precio1 <= 0 || precio2 <= 0 || precio3 <= 0 || cantidadUnidades1 <= 0 || cantidadUnidades2 <= 0 || cantidadUnidades3 <= 0)
        {
            Debug.Log("alguno de los precios o cantidades de productos es menor o igual a cero, cambie el valor para que deje de serlo");
        }
        else
        {
            if (cantidadUnidades1 > 3)
            {
                descuento1 = precioTodos1 / 100 * 20;
                precioTodos1 = precioTodos1 - descuento1;
            }
            if (cantidadUnidades2 > 3)
            {
                descuento2 = precioTodos2 / 100 * 20;
                precioTodos2 = precioTodos2 - descuento2;
            }
            if (cantidadUnidades3 > 3)
            {
                descuento3 = precioTodos3 / 100 * 20;
                precioTodos3 = precioTodos3 - descuento3;
            }

           
            descuentoTotal = descuento1 + descuento2 + descuento3;


            Debug.Log("El monto sin descuento por la compra de " + producto1 + ", " + producto2 + ", " + producto3 + "es: $" + montoTotal);

            if (descuentoTotal == 0)
            {
                Debug.Log("como no se superaron las 3 unidades en ningún producto no se aplicó un descuento");
            }
            else
            {
                totalMasDescuentos = montoTotal - descuentoTotal;
                Debug.Log("El total con descuento es: $" + totalMasDescuentos);
                Debug.Log("EL total descontado es: $" + descuentoTotal);
            }
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//El supermercado TicMarket nos pide que realicemos un programa para que sus clientes puedan calcular el costo de algunos productos
//que se encuentran en promoción

//Se pide que se ingrese por inspector:
//. Los nombre de tres productos
//.Los precios de cada producto
//.La cantidad de unidades deseada de cada producto

//El programa debe cumplir los siguientes requerimientos:

//Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

//El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

//El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento,
//el monto de los descuentos aplicados y el total con los descuentos aplicados.
