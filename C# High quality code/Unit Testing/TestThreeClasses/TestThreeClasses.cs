using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Here are located all tests, normally it will be better to have them split
 * class by class, but having 3 clases with 1 or 2 basic functionalities, it's just
 * easier to have em like this.
 */
[TestClass]
public class TestThreeClasses
{
    /// <summary>
    /// Tests if school is created.
    /// </summary>
    [TestMethod]
    public void TestSchoolCreation()
    {
        School testSchool = new School();
        Assert.IsNotNull(testSchool);
    }

    /// <summary>
    /// Tests if student is created.
    /// </summary>
    [TestMethod]
    public void TestStudentCreation()
    {
        School testSchool = new School();
        Assert.IsNotNull(testSchool);
        Student testStudent = new Student("Pesho", testSchool);
        Assert.IsNotNull(testStudent);
    }

    /// <summary>
    /// Tests if first student's id is 10 000.
    /// </summary>
    [TestMethod]
    public void TestStudentId()
    {
        School testSchool = new School();
        Assert.IsNotNull(testSchool);
        Student testStudent = new Student("Pesho", testSchool);
        Assert.IsNotNull(testStudent);
        Assert.AreEqual(10000, testStudent.UniqueId);
    }

    /// <summary>
    /// Test if next students Id is bigger with one.
    /// </summary>
    [TestMethod]
    public void TestStudentIdSequence()
    {
        School testSchool = new School();
        Assert.IsNotNull(testSchool);
        Student testStudent = new Student("Pesho", testSchool);
        Assert.AreEqual(10000, testStudent.UniqueId);
        Student testStudent2 = new Student("Gosho", testSchool);
        Assert.AreEqual(10001, testStudent2.UniqueId);
    }

    /// <summary>
    /// Tests if the last student id is the correct one.
    /// </summary>
    [TestMethod]
    public void TestStudentIdBounderiesPositive()
    {
        School testSchool = new School();
        Assert.IsNotNull(testSchool);
        for (int i = 0; i < 89999; i++)
        {
            new Student("Name", testSchool);
        }

        Assert.AreEqual(89999, testSchool.UniqueIds.Count);
    }

    /// <summary>
    /// Tests if more student with Id bigger than 99 999 could be created.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestStudentIdBounderiesNegative()
    {
        School testSchool = new School();
        Assert.IsNotNull(testSchool);
        for (int i = 0; i < 90000; i++)
        {
            new Student("Name", testSchool);
        }
    }

    /// <summary>
    /// Tests if correct exception is thrown then student's name is empty.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestStudentNameEmpty()
    {
        School testSchool = new School();
        Student testStudent = new Student(string.Empty, testSchool);
    }

    /// <summary>
    /// Test student adding a course.
    /// </summary>
    [TestMethod]
    public void TestStudentAddCourse()
    {
        School testSchool = new School();
        Student testStudent = new Student("John", testSchool);
        Course programming = new Course();
        Student.AddCourse(testStudent, programming);

        Assert.AreEqual(1, programming.StudentsList.Count);
        Assert.AreEqual(testStudent.UniqueId, programming.StudentsList[0].UniqueId);
    }

    /// <summary>
    /// Test student removing a course.
    /// </summary>
    [TestMethod]
    public void TestStudentRemoveCourse()
    {
        School testSchool = new School();
        Student testStudent = new Student("John", testSchool);
        Course programming = new Course();
        Student.AddCourse(testStudent, programming);

        Assert.AreEqual(1, programming.StudentsList.Count);
        Assert.AreEqual(testStudent.UniqueId, programming.StudentsList[0].UniqueId);

        Student.LeaveCourse(testStudent, programming);
        Assert.IsTrue(programming.StudentsList.Count == 0);
    }

    /// <summary>
    /// Tests if a student tries to remove himself from a course he's not participating at.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestStudentRemoveCourseNegative()
    {
        School testSchool = new School();
        Student testStudent = new Student("John", testSchool);
        Course programming = new Course();
        Student.LeaveCourse(testStudent, programming);
        Assert.IsTrue(programming.StudentsList.Count == 0);
    }

    /// <summary>
    /// Tests the upper borer case of students count in course.
    /// </summary>
    [TestMethod]
    public void TestCourseMaxStudentsPositive()
    {
        School testSchool = new School();
        Course programming = new Course();
        for (int i = 0; i < 29; i++)
        {
            Student student = new Student("name", testSchool);
            Student.AddCourse(student, programming);
        }

        Assert.IsTrue(programming.StudentsList.Count == 29);
    }

    /// <summary>
    /// Tests if correct exception is thrown when 30 or more student apply for course.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestCourseMaxStudentsNegative()
    {
        School testSchool = new School();
        Course programming = new Course();
        for (int i = 0; i < 30; i++)
        {
            Student student = new Student("name", testSchool);
            Student.AddCourse(student, programming);
        }
    }
}