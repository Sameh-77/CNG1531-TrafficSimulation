// **************************************************************************************************
//		FederateSom
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
  public class FederateSom : Racon.ObjectModel.CObjectModel
  {
    #region Declarations
    #region SOM Declaration
    public TrafficSimulation.Som.CTrafficLightOC TrafficLightOC;
    public TrafficSimulation.Som.CVehicleOC VehicleOC;
    public TrafficSimulation.Som.CtrafficLightMessageIC trafficLightMessageIC;
    #endregion
    #endregion //Declarations
    
    #region Constructor
    public FederateSom() : base()
    {
      // Construct SOM
      TrafficLightOC = new TrafficSimulation.Som.CTrafficLightOC();
      AddToObjectModel(TrafficLightOC);
      VehicleOC = new TrafficSimulation.Som.CVehicleOC();
      AddToObjectModel(VehicleOC);
      trafficLightMessageIC = new TrafficSimulation.Som.CtrafficLightMessageIC();
      AddToObjectModel(trafficLightMessageIC);
    }
    #endregion //Constructor
  }
}
