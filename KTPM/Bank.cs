namespace KTPM { 
    public class Bank
    {
        const int MAXIMUM = 10000;
        const int MINIMUM = 100;
        const int THRESHOLD = 5000;

        public static string transfer(int money)
        {

            if (money < MINIMUM || money > MAXIMUM)
            {
                return "So tien khong hop le";
            }


            if (money > THRESHOLD)
            {
                return "So tien can duoc phe duyet";
            }

            return "So tien da duoc chuyen";
        }
    }

}