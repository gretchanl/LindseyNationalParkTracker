using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatlParkTracker
{

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
    
    /// <summary>
    /// This is data for each park from the Park Service
    /// </summary>
    public class MyVisit
    {
        #region Properties
        
        public string ParkName { get; set; }
        public string Abbreviation { get; set; } // like NP, NPL
        // public string Region { get; set; } - created an enum for this
        public string State { get; set; }
        public ParkRegion Region { get; set; }

        #endregion

        #region Methods

        public string MyVisit(string ParkName)
        {
            return visit1;
        }

        #endregion
    }
}
        