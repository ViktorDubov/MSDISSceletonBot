using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Tests.DataSystemTests.ModelTests
{
    public class WorkerTests
    {
        [Fact]
        public void Given_few_new_workers_When_initialized_Then_each_has_unique_ID()
        {
            // Act
            var worker1 = new Worker();
            var worker2 = new Worker();

            // Assert
            Assert.NotEqual(worker1.ID, worker2.ID);
        }

        [Fact]
        public void Given_customer_task_When_set_task_in_work_Then_IsBussy_is_true()
        {
            // Arrange
            var worker = new Worker();
            var task = new CustomerTask("Test Task");

            // Act
            worker.SetTaskInWork(task);

            // Assert
            Assert.True(worker.IsBussy);
            Assert.Equal(task, worker.TaskInWork);
        }

        [Fact]
        public void Given_worker_with_task_When_task_finished_Then_IsBussy_is_false()
        {
            // Arrange
            var worker = new Worker();
            var task = new CustomerTask("Test Task");
            worker.SetTaskInWork(task);

            // Act
            worker.FinishTaskInWork();

            // Assert
            Assert.False(worker.IsBussy);
        }

        [Fact]
        public void Given_worker_with_task_When_task_finished_Then_TaskInWork_is_null()
        {
            // Arrange
            var worker = new Worker();
            var task = new CustomerTask("Test Task");
            worker.SetTaskInWork(task);

            // Act
            worker.FinishTaskInWork();

            // Assert
            Assert.Null(worker.TaskInWork);
        }
    }
}
