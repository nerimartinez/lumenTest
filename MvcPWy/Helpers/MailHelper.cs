using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MvcPWy.Helpers
{
    public static class MailHelper
    {
        public static string SetupMail(string fname, string lname, List<Device> devices)
        {
            StringBuilder body = new StringBuilder();
            body.Append("Dear ");
            body.Append(fname);
            body.Append(" ");
            body.Append(lname);
            body.Append(",<br/>");
            body.Append("Thank you for your interest in our services.<br/>Here is the information you have provided about your devices.");


            body.Append("<table border=\"1\">");
            body.Append("<tr>");
            body.Append("<th>");
            body.Append("NickName");
            body.Append("</th>");
            body.Append("<th>");
            body.Append("Manufacturer");
            body.Append("</th>");
            body.Append("<th>");
            body.Append("Model");
            body.Append("</th>");
            body.Append("<th>");
            body.Append("Ip Type");
            body.Append("</th>");
            body.Append("<th>");
            body.Append("Ip Address");
            body.Append("</th>");
            body.Append("<th>");
            body.Append("Location");
            body.Append("</th>");
            body.Append("<th>");
            body.Append("Zip Code");
            body.Append("</th>");
            body.Append("<th>");
            body.Append("Policy");
            body.Append("</th>");
            body.Append("</tr>");
            foreach (var dev in devices)
            {
                body.Append("<tr>");
                body.Append("<td>");
                body.Append(dev.NickName);
                body.Append("</td>");
                body.Append("<td>");
                body.Append(dev.Manufacturer.Name);
                body.Append("</td>");
                body.Append("<td>");
                body.Append(dev.Model.Name);
                body.Append("</td>");
                body.Append("<td>");
                body.Append(dev.IpType);
                body.Append("</td>");
                body.Append("<td>");
                body.Append(dev.IpAddress);
                body.Append("</td>");
                body.Append("<td>");
                body.Append(dev.Location.Name);
                body.Append("</td>");
                body.Append("<td>");
                body.Append(dev.ZipCode);
                body.Append("</td>");
                body.Append("<td>");
                body.Append(dev.Policy.Value);
                body.Append("</td>");

                body.Append("</tr>");
            }
            body.Append("</table>");


            body.Append("<br/>Thank you<br/><br/>The Lumen21 Team");
            return body.ToString();
        }
    }
}