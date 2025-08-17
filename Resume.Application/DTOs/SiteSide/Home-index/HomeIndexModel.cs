using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs.SiteSide.Home_index;

public class HomeIndexModel
{
	#region Properties
	public List<Resume.Domain.Entities.Education> Educations { get; set; }
	public List<Resume.Domain.Entities.Experience> Experiences { get; set; }
	public List<Resume.Domain.Entities.MySkills> mySkills { get; set; }
	#endregion


}
