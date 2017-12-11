using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace MVC5Course.Models.DataTypes
{
    public class 身分證字號Attribute : DataTypeAttribute
    {
        public 身分證字號Attribute() : base(DataType.Text)
        {

        }
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            string str = (string)value;
            if (str.Contains("Eric"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}