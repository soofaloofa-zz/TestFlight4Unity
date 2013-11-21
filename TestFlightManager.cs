using UnityEngine;

public class TestFlightManager : MonoBehaviour
{	
	public string appToken = "xxxx-yyy-zzz";
	
	public bool disableInAppUpdates = false;
	public bool logOnCheckpoint = true;
	public bool enableLogToConsole = true;
	public bool enableSTDErrLogger = true;
	public bool reportCrashes = true;
	public bool sendLogOnlyOnCrash = false;

	private void Awake()
	{
		TestFlightBinding.DisableInAppUpdates(disableInAppUpdates);
		TestFlightBinding.LogOnCheckpoint(logOnCheckpoint);
		TestFlightBinding.EnableLogToConsole(enableLogToConsole);
		TestFlightBinding.EnableSTDErrLogger(enableSTDErrLogger);
		TestFlightBinding.ReportCrashes(reportCrashes);
		TestFlightBinding.SendLogOnlyOnCrash(sendLogOnlyOnCrash);
		
		TestFlightBinding.TakeOff (appToken);
	}
}
