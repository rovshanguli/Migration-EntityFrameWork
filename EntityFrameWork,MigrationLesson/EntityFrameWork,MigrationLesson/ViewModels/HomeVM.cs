using EntityFrameWork_MigrationLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MigrationLesson.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail Detail { get; set; }
    }
}
