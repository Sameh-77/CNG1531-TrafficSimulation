// **************************************************************************************************
//		CTrafficLightOC
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Sunday, January 30, 2022 4:43:41 PM
//		compatible with		: 	RACoN v.0.0.2.5
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// This class is extended from the object model of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using TrafficSimulation.Som;


namespace TrafficSimulation.Som
{
  public class CTrafficLightOC : HlaObjectClass
  {
    #region Declarations
    #endregion //Declarations
    
    #region Constructor
    public CTrafficLightOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.TrafficLight";
      ClassPS = PSKind.Subscribe;
      
      // Create Attributes
    }
    #endregion //Constructor
  }
}
