namespace eticaret.Models
{
    public static class GetFormattedPhoneNumber
    {
        public static string PhoneNumberFormatted(this string phone)
        {
            if (phone != null && phone.Trim().Length == 11)
                return string.Format("{0}({1}) {2} {3} {4}", phone.Substring(0, 1),  phone.Substring(1, 3), phone.Substring(4, 3), phone.Substring(7, 2), phone.Substring(9, 2));
            return phone;
        }
    }
}
