using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(1, job2.Id - job1.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsNotNull (job.Id);
            Assert.AreEqual("Product tester", job.Name);
            Assert.AreEqual("ACME", job.EmployerName.ToString());
            Assert.AreEqual("Desert", job.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job.JobType.ToString());
            Assert.AreEqual("Persistence", job.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreNotEqual(job1, job2);
        }

        [TestMethod, TestCategory("Job.ToString()")]
        public void TestBlankLines()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobStr = job.ToString();

            Assert.AreEqual("\n", jobStr[..1]);//range operator
            Assert.AreEqual("\n", jobStr[^1..]);
        }

        [TestMethod, TestCategory("Job.ToString()")]
        public void TestLabeledData()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobStr = $"\nID: {job.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n";

            Assert.AreEqual(jobStr, job.ToString());
        }

        [TestMethod, TestCategory("Job.ToString()")]
        public void TestEmptyField()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));

            string jobStr = $"\nID: {job.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Data not available\n";

            Assert.AreEqual(jobStr, job.ToString());
        }

        [TestMethod, TestCategory("Job.ToString()")]
        public void TestJobExistence()
        {
            Job job = new Job();
            Assert.AreEqual("\nOOPS! This job does not seem to exist.\n", job.ToString());
        }

        [TestMethod]
        public void TestClassEquality()
        {
            Employer acme = new Employer("ACME");
            Assert.IsTrue(acme.Equals(acme));
        }
    }
}
