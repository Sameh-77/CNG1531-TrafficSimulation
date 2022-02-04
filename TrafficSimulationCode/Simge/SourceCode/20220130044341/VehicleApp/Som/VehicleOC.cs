// **************************************************************************************************
//		CVehicleOC
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
  public class CVehicleOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute id;
    public HlaAttribute counter;
    public HlaAttribute emergencyStatus;
    public HlaAttribute vehicleStatus;
    public HlaAttribute position;
    #endregion //Declarations
    
    #region Constructor
    public CVehicleOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Vehicle";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // id
      id = new HlaAttribute("id", PSKind.PublishSubscribe);
      Attributes.Add(id);
      // counter
      counter = new HlaAttribute("counter", PSKind.PublishSubscribe);
      Attributes.Add(counter);
      // emergencyStatus
      emergencyStatus = new HlaAttribute("emergencyStatus", PSKind.PublishSubscribe);
      Attributes.Add(emergencyStatus);
      // vehicleStatus
      vehicleStatus = new HlaAttribute("vehicleStatus", PSKind.PublishSubscribe);
      Attributes.Add(vehicleStatus);
      // position
      position = new HlaAttribute("position", PSKind.PublishSubscribe);
      Attributes.Add(position);
    }
    #endregion //Constructor
  }
}
