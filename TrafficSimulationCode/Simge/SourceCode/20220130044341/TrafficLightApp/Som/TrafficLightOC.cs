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
    public HlaAttribute position;
    public HlaAttribute status;
    public HlaAttribute timer;
    #endregion //Declarations
    
    #region Constructor
    public CTrafficLightOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.TrafficLight";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // position
      position = new HlaAttribute("position", PSKind.PublishSubscribe);
      Attributes.Add(position);
      // status
      status = new HlaAttribute("status", PSKind.PublishSubscribe);
      Attributes.Add(status);
      // timer
      timer = new HlaAttribute("timer", PSKind.PublishSubscribe);
      Attributes.Add(timer);
    }
    #endregion //Constructor
  }
}
