using RouxAcademyWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouxAcademyWebApp.Models {
public 	class IndexViewModel {
		public IEnumerable<SchoolEvent> SchoolEvents { get; set; }
	}
}
