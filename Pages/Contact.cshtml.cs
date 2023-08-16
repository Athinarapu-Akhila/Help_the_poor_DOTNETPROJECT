using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace project.Pages
{
   
   
    public class Contact: PageModel
        {
            public class FormTableData
            {
        
                public required string name { get; set; }
                public  required string gender {get;set;}
                public required int phoneno { get; set; }
                public required string SelectedItem { get; set; }
                public required string address {get;set;}
                public required string reason {get;set;}
            }
        [BindProperty]
        public List<FormTableData> DataList { get; set; } = new List<FormTableData>();
        public required string SelectedItem { get; set; }
        
        public required List<string> Items { get; set; } =new List<string>();
            public void OnGet()
            {
                Items = new List<string>
                {
                "India",
                "USA",
                "Pakisthan",
                "Srilanka"
                // Add more items here
                };
            }
            public IActionResult OnPost(string n,string g, int ph,string selectedItem,string a,string r)
            {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DataList.Add(new FormTableData { name = n,gender=g, phoneno= ph,SelectedItem = selectedItem,address=a,reason=r});
            return Page();
        }
    }
}