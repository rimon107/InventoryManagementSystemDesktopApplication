using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IMS.Data.DAL.IContext;
using IMS.Data.Model;
using System.Collections.Generic;
using IMS.Service.BLL;
using System.ComponentModel;

namespace IMS.Service.Tests.UnitTests
{
    [TestClass]
    public class GenericContextTest
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}

        private Mock<IContext<Receive>> mock;
        private List<Receive> store;

        [TestInitialize]
        public void TestInitialize()
        {
            store = new List<Receive>();

            mock = new Mock<IContext<Receive>>();
            mock.Setup(m => m.GetAll()).Returns(store);
            mock.Setup(m => m.Create(It.IsAny<Receive>())).Callback<Receive>(receive => store.Add(receive));
            mock.Setup(m => m.Delete(It.IsAny<Receive>())).Callback<Receive>(receive => store.Remove(receive));
            mock.Setup(m => m.Update(It.IsAny<Receive>())).Callback<Receive>(receive =>
                                                                            {
                                                                                int i = store.IndexOf(receive);
                                                                                store[i] = receive;
                                                                            });

        }


        [TestMethod]
        public void SaveCommand_OnCreateIContextContextReceive()
        {
            //Arrange
            var receive = new Receive
            {
                ChallanDate = DateTime.Now,
                ChallanNo = "ch-1",
                EntryDate = DateTime.Now,
                EntryBy = "admin",
                FiscalYear = 2018,
                GRNDate = DateTime.Now,
                GRNNo = "GRN-1",
                PlantId = "1",
                ReceiveReferenceNo = "RR-1",
                ReceiveText = "test",
                SupplierId = "s-1",
                VATChallanDate = DateTime.Now,
                VATChallanNo = "VC-1"
            };

            //mock.Object.Create(receive);

            var GenContext = new GenericContext<Receive>(mock.Object)
                            {
                                Entity = receive
                            };
            //Act
            var res = GenContext.Create();

            //Assert
            Assert.IsTrue(GenContext.EntityList.Count == 1);
        }
        
        [TestMethod]
        public void SaveCommand_OnUpdateIContextContextReceive()
        {
            //Arrange
            var receive = new Receive
            {
                ChallanDate = DateTime.Now,
                ChallanNo = "ch-1",
                EntryDate = DateTime.Now,
                EntryBy = "admin",
                FiscalYear = 2018,
                GRNDate = DateTime.Now,
                GRNNo = "GRN-1",
                PlantId = "1",
                ReceiveReferenceNo = "RR-1",
                ReceiveText = "test",
                SupplierId = "s-1",
                VATChallanDate = DateTime.Now,
                VATChallanNo = "VC-1"
            };

            mock.Object.Create(receive);

            var GenContext = new GenericContext<Receive>(mock.Object);
            
            GenContext.SetEntityList();
            //GenContext.Entity = GenContext.EntityList.

            //Act
            //GenContext.Entity.ChallanNo = "10";
            //GenContext.Update();

            //Assert
            mock.Verify(m => m.Update(It.IsAny<Receive>()), Times.Once);
        }
    }
}
