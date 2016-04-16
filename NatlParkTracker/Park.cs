using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatlParkTracker
{
    /// <summary>
    /// This is data for each national park
    /// </summary>
    /// 
    public enum ParkRegion
    {
        Alaska,
        Northeast,
        InterMountain,
        Midwest,
        NationalCapital,
        PacificWest, 
        Southeast
    }
    
    
    public class Park
    {
        #region Properties
        
        public string ParkName { get; set; }
        public string Abbrev { get; set; } // like NP, NPL
        // public string Region { get; set; } - created an enum for this
        public string State { get; set; }
        public ParkRegion Region { get; set; }

        #endregion

        #region Methods

        

        #endregion
    }
}
        