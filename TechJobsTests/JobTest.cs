using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TechJobsOO;
namespace TechJobsTests
{
    [TestClass]
    public class JobTest
    {
        Job testJob1;
        Job testJob2;
        Job testJob3;
        [TestInitialize]
        public void CreateJobs()
        {
            testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            testJob3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
           Assert.IsTrue(testJob1.Name == "Product tester" && testJob1.EmployerName.Value == "ACME" && testJob1.EmployerLocation.Value == "Desert" && testJob1.JobType.Value == "Quality control" && testJob1.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1Clone = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(testJob1.Equals(testJob1Clone));
        }
        [TestMethod]
        public void TestIncludesNewLinesBeforeAndAfterStrings()
        {
            
            Assert.IsTrue(testJob1.ToString()[0] == '\n');
            Assert.IsTrue(testJob1.ToString()[testJob1.ToString().Count()-1] == '\n');
        }
        [TestMethod]
        public void TestLabelEachLineOfData()
        {
            Console.WriteLine(testJob1);
            Assert.AreEqual(testJob1.ToString(), "\n" + $"Name: {testJob1.Name}" + "\n" + $"Employer: {testJob1.EmployerName.Value}" + "\n" + $"Location: {testJob1.EmployerLocation.Value}" + "\n" + $"Position Type: {testJob1.JobType.Value}" + "\n" + $"Core Competency: {testJob1.JobCoreCompetency.Value}\n");
        }
        [TestMethod]
        public void TestErrorMessageForBlankField()
        {

        }
    }
}
