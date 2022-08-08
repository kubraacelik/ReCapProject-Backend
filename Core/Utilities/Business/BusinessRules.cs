using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //params verdiğin zaman Run'a istediğin kadar IResult verebilirsin
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) //logic'in success durumu başarısız ise business'e söylüyor
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
