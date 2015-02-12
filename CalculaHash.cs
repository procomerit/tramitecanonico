 public static string MD5Hash(string text)
    {
      MD5 md5 = new MD5CryptoServiceProvider();
      
      //calcula hash a partir de los bytes de text 
      md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
 
      //Resultado del hash depués de calcularlo 
      byte[] result = md5.Hash;
 
      StringBuilder strBuilder = new StringBuilder();
      for (int i = 0; i < result.Length; i++)
      {
        //2 digitos hexadecimales para cada bye 
        strBuilder.Append(result[i].ToString("x2"));
      }
 
      return strBuilder.ToString();
    }
