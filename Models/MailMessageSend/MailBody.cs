namespace eticaret.Models.MailMessageSend
{
    public static class MailBody
    {
        public static string mailBody(this string modelState, string link, string adsoyad)
        {
            var body = "";

            return body;
        }

        public static string mailBody(string link, string adsoyad)
        {
            var body = $@"<table width='100%' border='0' cellspacing='0' cellpadding='0'>
                            <tr>
                                <td align='center' style='padding: 20px;'>
                                    <table class='content' width='600' border='0' cellspacing='0' cellpadding='0' style='border-collapse: collapse; border: 1px solid #cccccc;'>
                                        <tr>
                                            <td class='header' style='background-color: #345C72; padding: 40px; text-align: center; color: white; font-size: 24px;'>
                                                Sayın {adsoyad}                      
                                            </td>
                                        </tr>
                                        <tr>                        
                                            <td class='body' style='padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;'>
                                                Merhaba, {adsoyad} <br> Lorem odio soluta quae dolores sapiente voluptatibus recusandae aliquam fugit ipsam.
                                                <br><br>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit. Incidunt, officia facilis  atque? Ipsam voluptas fugiat distinctio blanditiis veritatis.            
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style='padding: 0px 40px 0px 40px; text-align: center;'>
                                                <table cellspacing='0' cellpadding='0' style='margin: auto;'>
                                                    <tr>
                                                        <td align='center' style='background-color: #345C72; padding: 10px 20px; border-radius: 5px;'>
                                                            {link}
                                                        </td>
                                                    </tr>
                                                </table>
                                             </td></tr>
                                        <tr>
                                            <td class='body' style='padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;'>
                                                Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit.
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class='footer' style='background-color: #333333; padding: 40px; text-align: center; color: white; font-size: 14px;'>
                                                    Copyright &copy; 2024
                                            </td>
                                        </tr>
                                    </table>
                                </td>  
                            </tr>
                        </table>";

            return body;
        }
    }
}
