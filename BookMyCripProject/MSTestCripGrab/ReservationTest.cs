namespace MSTestCripGrab;
using BookMyCripProject.Shared.Models;

[TestClass]
public class ReservationTest
{
    [TestMethod]
    public void TestStartDateBeforeDateNow()
    {
        Reservation reservation = new Reservation();

        DateTime date = DateTime.Now;

        if (reservation.ReservationStartDate < date)
        {
            Assert.Fail();
        }
    }

    public void TestEndDateAfterStartDate()
    {
        Reservation reservation = new Reservation();

        if (reservation.ReservationEndDate < reservation.ReservationStartDate)
        {
            Assert.Fail();
        }
    }


}
