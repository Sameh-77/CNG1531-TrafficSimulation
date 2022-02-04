// **************************************************************************************************
//		CSimulationManager
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
/// The Simulation Manager manages the (multiple) federation execution(s) and the (multiple instances of) joined federate(s).
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using TrafficSimulation.Som;

namespace TrafficSimulation
{
  public class CSimulationManager
  {
    #region Declarations
    // Communication layer related structures
    public CTrafficLightApp federate; //Application-specific federate 
    // Local data structures
    // TODO: user-defined data structures are declared here
    #endregion //Declarations
    
    #region Constructor
    public CSimulationManager()
    {
      // Initialize the application-specific federate
      federate = new CTrafficLightApp(this);
      // Initialize the federation execution
      federate.FederationExecution.Name = "TrafficFederation";
      federate.FederationExecution.FederateType = "TrafficLight";
      federate.FederationExecution.ConnectionSettings = "rti://127.0.0.1";
      // Handle RTI type variation
      initialize();
    }
    #endregion //Constructor
    
    #region Methods
    // Handles naming variation according to HLA specification
    private void initialize()
    {
      switch (federate.RTILibrary)
      {
        case RTILibraryType.HLA13_DMSO: case RTILibraryType.HLA13_Portico: case RTILibraryType.HLA13_OpenRti:
                federate.Som.TrafficLightOC.Name = "objectRoot.TrafficLight";
                federate.Som.TrafficLightOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.VehicleOC.Name = "objectRoot.Vehicle";
                federate.Som.VehicleOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.trafficLightMessageIC.Name = "interactionRoot.trafficLightMessage";
                federate.FederationExecution.FDD = @".\TrafficSimulationFOM.fed";
        break;
        case RTILibraryType.HLA1516e_Portico: case RTILibraryType.HLA1516e_OpenRti:
                federate.Som.TrafficLightOC.Name = "HLAobjectRoot.TrafficLight";
                federate.Som.TrafficLightOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.VehicleOC.Name = "HLAobjectRoot.Vehicle";
                federate.Som.VehicleOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.trafficLightMessageIC.Name = "HLAinteractionRoot.trafficLightMessage";
                federate.FederationExecution.FDD = @".\TrafficSimulationFOM.xml";
        break;
      }
    }
    #endregion //Methods
  }
}
