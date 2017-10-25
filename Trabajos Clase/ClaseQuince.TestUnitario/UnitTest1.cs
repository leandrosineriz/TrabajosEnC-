using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaseQuince.Deposito;

namespace ClaseQuince.TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InicializarLista()
        {
            Depositos<Auto> d = new Depositos<Auto>(5);
            //Verifico que la lista no esté vacía
            Assert.IsNotNull(d.Lista);
        }

        [TestMethod]
        public void EspacioIncorrecto()
        {
            // Corroboro que el espacio no pueda ser mayor a 50
            Depositos<Auto> grande = new Depositos<Auto>(51);
            if (grande.Capacidad != 50)
                Assert.Fail("Espacio disponible mal validado: {0}.", grande.Capacidad);

            // Corroboro que el espacio no pueda ser menor a 1
            Depositos<Auto> chico = new Depositos<Auto>(0);
            Assert.AreNotEqual(chico.Capacidad, 0);
            if (chico.Capacidad != 1)
                Assert.Fail("Espacio disponible mal validado: {0}.", chico.Capacidad);

            // Corroboro si el espacio es el mismo que cargo
            Depositos<Auto> correcto = new Depositos<Auto>(20);
            Assert.AreEqual(correcto.Capacidad, 20);
        }

        [TestMethod]
        public void AgregaDepositoLleno()
        {
            Depositos<Auto> d = new Depositos<Auto>(2);
            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");
            Auto a3 = new Auto("Negro", "BMW");
            Assert.
            d.Agregar(a1);
            d.Agregar(a2);
            try
            {
                Assert.IsTrue(d.Agregar(a3));
                Assert.Fail("Debería avisar que el aula está llena.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DepositoLlenoExeption));
            }

        }

        [TestMethod]
        public void AgregaEspacioDisponible()
        {
            Depositos<Auto> d = new Depositos<Auto>(2);
            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");

            d.Agregar(a1);
            Assert.AreEqual(d.Capacidad, 1);
            d.Agregar(a2);
            Assert.AreEqual(d.Capacidad, 0);
        }

        //#1- AGREGAR TESTMETHOD QUE VERIFIQUE EL CORRECTO FUNCIONAMIENTO DE '+'
        [TestMethod]
        public void AgregarConMas()
        {
            Depositos<Auto> d = new Depositos<Auto>(2);

            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");
            Auto a3 = new Auto("Verde", "Mustang");

            if (d + a1)
                Assert.AreEqual(d.Capacidad, 1);

            Assert.IsTrue(d + a3);



        }

        //#2- AGREGAR TESTMETHOD QUE VERIFIQUE EL CORRECTO FUNCIONAMIENTO DE 'REMOVER' / '-'

        [TestMethod]
        public void RemoverLista()
        {
            Depositos<Auto> d = new Depositos<Auto>(3);

            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");
            Auto a3 = new Auto("Verde", "Mustang");

            d.Agregar(a1);
            d.Agregar(a2);
            d.Agregar(a3);

            Assert.IsTrue(d.Remover(a1));
            Assert.IsTrue(d.Remover(a2));
            Assert.IsTrue(d.Remover(a3));

            Assert.IsFalse(d.Remover(a1));

            Assert.AreEqual(d.Capacidad, 3);

        }
    }
}
