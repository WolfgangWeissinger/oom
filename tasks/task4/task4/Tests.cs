using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace task3._1
{
    [TestFixture]
    public class Tests
    {
        // Bouncers
        [Test]
        public void Weekday_Price_Compare_with_Initialization()
        {
            var x = new RentalObjects_bouncer("Babytreff", 36, 39, 59, 10);
            Assert.IsTrue(x.Price_weekdays == 36);
        }
        [Test]
        public void Weekend_Price_Compare_with_Initialization()
        {
            var x = new RentalObjects_bouncer("Babytreff", 36, 39, 59, 10);
            Assert.IsTrue(x.Price_weekends == 39);
        }
        [Test]
        public void F48h_Price_Compare_with_Initialization()
        {
            var x = new RentalObjects_bouncer("Babytreff", 36, 39, 59, 10);
            Assert.IsTrue(x.Price_48h == 59);
        }
        [Test]
        public void No_negative_price_weekdays()
        {
            Assert.Catch(() => { var x = new RentalObjects_bouncer("Babytreff", -36, 39, 59, 10); });
        }

        [Test]
        public void No_negative_price_weekends()
        {
            Assert.Catch(() => { var x = new RentalObjects_bouncer("Babytreff", 36, -39, 59, 10); });
        }

        [Test]
        public void No_negative_price_48h()
        {
            Assert.Catch(() => { var x = new RentalObjects_bouncer("Babytreff", 36, 39, -59, 10); });
        }
        [Test]
        public void No_negative_weight()
        {
            Assert.Catch(() => { var x = new RentalObjects_bouncer("Babytreff", 36, 39, 59, -10); });
        }
        [Test]
        public void Atleast_one_day_booking_delivery()
        {
            var y = new RentalObjects_bouncer("Babytreff", 36, 39, 59, 10);

            Assert.Catch(() => {
                
                y.price_calculation_delivery(y.Price_weekdays, -3); });
        }
        [Test]
        public void Atleast_one_day_booking_pickup()
        {
            var y = new RentalObjects_bouncer("Babytreff", 36, 39, 59, 10);

            Assert.Catch(() => {

                y.price_calculation_pickup(y.Price_weekdays, -3);
            });
        }

        // Skydancers
        [Test]
        public void Skydancer_Weekday_Price_Compare_with_Initialization()
        {
            var x = new RentalObjects_skydancer("Babytreff", 36, 39, 59, 10);
            Assert.IsTrue(x.prop_price_weekdays == 36);
        }
        [Test]
        public void Skydancer_Weekend_Price_Compare_with_Initialization()
        {
            var x = new RentalObjects_skydancer("Babytreff", 36, 39, 59, 10);
            Assert.IsTrue(x.prop_price_weekends == 39);
        }
        [Test]
        public void Skydancer_48h_Price_Compare_with_Initialization()
        {
            var x = new RentalObjects_skydancer("Babytreff", 36, 39, 59, 10);
            Assert.IsTrue(x.prop_price_48h == 59);
        }
        [Test]
        public void Skydancer_No_negative_price_weekdays()
        {
            Assert.Catch(() => { var x = new RentalObjects_skydancer("Babytreff", -36, 39, 59, 10); });
        }

        [Test]
        public void Skydancer_No_negative_price_weekends()
        {
            Assert.Catch(() => { var x = new RentalObjects_skydancer("Babytreff", 36, -39, 59, 10); });
        }

        [Test]
        public void Skydancer_No_negative_price_48h()
        {
            Assert.Catch(() => { var x = new RentalObjects_skydancer("Babytreff", 36, 39, -59, 10); });
        }
        [Test]
        public void Skydancer_No_negative_weight()
        {
            Assert.Catch(() => { var x = new RentalObjects_skydancer("Babytreff", 36, 39, 59, -10); });
        }
    }
}
