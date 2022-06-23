namespace ZohaSite
{
    public static class ClientValidation
    {
        public static List<string> ForbiddenSymbols = new List<string>() {"!","@","$","%","^","&","*","(",")","-","+","=","?","."};
        private static bool issame;

        public static bool SimpleValid(string any)
        {

            if (any != string.Empty && !any.Contains(' ')&& any != null)
            {
                foreach (var item in ForbiddenSymbols)
                {
                    if (!any.Contains(item))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    
                    }
                }
                return false;

            }
            else
            {
                return false;
            }

        }


        public static bool ExistingLogin(string Login)
        {
            foreach (var item in EtoBasa.clients)
            {
                if (Login==item.Login)
                {
                    break;
                    return false;
                }

            }
            return true;
        }







    }
}
