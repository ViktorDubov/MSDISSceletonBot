using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Tests.DataSystemTests.ModelTests
{
    public class IDSetterTests
    {
        [Fact]
        public void Given_new_customer_When_get_id_Then_unique_id_is_returned()
        {
            // Arrange
            IDSetter.RestoreIDSetter();

            // Act
            var id1 = IDSetter.GetCustomerID();
            var id2 = IDSetter.GetCustomerID();

            // Assert
            Assert.NotEqual(id1, id2);
            Assert.Equal("1", id1);
            Assert.Equal("2", id2);
        }

        [Fact]
        public void Given_new_customer_task_When_get_id_Then_unique_id_is_returned()
        {
            // Arrange
            IDSetter.RestoreIDSetter();

            // Act
            var id1 = IDSetter.GetCustomerTaskID();
            var id2 = IDSetter.GetCustomerTaskID();

            // Assert
            Assert.NotEqual(id1, id2);
            Assert.Equal("1", id1);
            Assert.Equal("2", id2);
        }

        [Fact]
        public void Given_new_worker_When_get_id_Then_unique_id_is_returned()
        {
            // Arrange
            IDSetter.RestoreIDSetter();

            // Act
            var id1 = IDSetter.GetWorkerID();
            var id2 = IDSetter.GetWorkerID();

            // Assert
            Assert.NotEqual(id1, id2);
            Assert.Equal("1", id1);
            Assert.Equal("2", id2);
        }

        [Fact]
        public void Given_id_setter_When_restore_Then_counters_are_reset()
        {
            // Act
            IDSetter.RestoreIDSetter();

            var customerID = IDSetter.GetCustomerID();
            var customerTaskID = IDSetter.GetCustomerTaskID();
            var workerID = IDSetter.GetWorkerID();

            // Assert
            Assert.Equal("1", customerID);
            Assert.Equal("1", customerTaskID);
            Assert.Equal("1", workerID);
        }
    }
}