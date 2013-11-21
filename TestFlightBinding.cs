using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

/// <summary>
/// TestFlight SDK Unity binding. For most use cases calling TestFlightBinding.TakeOff("<app_token>"); 
/// during your application initialization phase is sufficient to use TestFlight. If you require more 
/// configuration or management the functions listed below.
/// 
/// Your TestFlight App Token is available from testflightapp.com.
/// 
/// Copyright (C) 2013, Red Finch Software. All rights reserved.
/// </summary>
public class TestFlightBinding 
{		
	#region Objective-C Bindings
	
	[DllImport("__Internal")]
    private static extern bool _AddCustomEnvironmentInformation (string information, string key);
	
	[DllImport("__Internal")]
    private static extern bool _TakeOff(string applicationToken);
	
	[DllImport("__Internal")]
    private static extern bool _PassCheckpoint(string checkpoint);
	
	[DllImport("__Internal")]
    private static extern bool _SubmitFeedback(string feedback);

	[DllImport("__Internal")]
    private static extern bool _Log(string message);
	
	[DllImport("__Internal")]
    private static extern bool _DisableInAppUpdates(bool enabled);

	[DllImport("__Internal")]
    private static extern bool _FlushSecondsInterval(int seconds);

	[DllImport("__Internal")]
    private static extern bool _LogOnCheckpoint(bool enabled);

	[DllImport("__Internal")]
    private static extern bool _EnableLogToConsole(bool enabled);

	[DllImport("__Internal")]
    private static extern bool _EnableSTDErrLogger(bool enabled);
	
	[DllImport("__Internal")]
    private static extern bool _ReportCrashes(bool enabled);	
	
	[DllImport("__Internal")]
    private static extern bool _SendLogOnlyOnCrash(bool enabled);	
	
	[DllImport("__Internal")]
    private static extern bool _SessionKeepAliveTimeout(int seconds);		
	
	#endregion
	
	#region Unity Bindings
	
	/// <summary>
	/// Adds custom environment information to the current session.
	/// If you want to track custom information such as a user name from your application you can add it here.
	/// </summary>
	/// <param name='information'>
	/// A string containing the information you are storing.
	/// </param>
	/// <param name='key'>
	/// The key to store the information with.
	/// </param>
	public static void AddCustomEnvironmentInformation (string information, string key)
	{
        if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_AddCustomEnvironmentInformation(information, key);
	}
	
	/// <summary>
	/// Starts a TestFlight session using the Application Token for this Application.
	/// </summary>
	/// <param name='applicationToken'>
	/// Will be the application token for the current application..
	/// </param>
	public static void TakeOff(string applicationToken)
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_TakeOff(applicationToken);
	}
	
	/// <summary>
	/// Track when a user has passed a checkpoint after a TestFlight session has started.
	/// </summary>
	/// <param name='checkpoint'>
	/// The name of the checkpoint.
	/// </param>
	public static void PassCheckpoint(string checkpoint) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_PassCheckpoint(checkpoint);
	}
	
	/// <summary>
	/// Submits custom feedback to the site. Sends the data in feedback to the site. This is to be used as the method to submit
	/// feedback from custom feedback forms.
	/// </summary>
	/// <param name='feedback'>
	/// Your users feedback, method does nothing if feedback is null.
	/// </param>
	public static void SubmitFeedback(string feedback) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_SubmitFeedback(feedback);
	}
	
	/// <summary>
	/// Log the specified message using remote logging.
	/// </summary>
	/// <param name='message'>
	/// The message to log.
	/// </param>
	public static void Log(string message) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_Log(message);
	}
	
	/// <summary>
	/// Defaults to false. Setting to true disables the in app update screen shown in BETA apps 
	/// when there is a new version available on TestFlight.
	/// </summary>
	/// <param name='enabled'>
	/// Enable or disable in app updates.
	/// </param>
	public static void DisableInAppUpdates(bool enabled) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_DisableInAppUpdates(enabled);
	}
	
	/// <summary>
	/// Defaults to 60. 0 turns off the flush timer. 30 seconds is the minimum flush interval.
	/// </summary>
	/// <param name='seconds'>
	/// The interval where all logs and data are written out to disk.
	/// </param>
	public static void FlushSecondsInterval(int seconds) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_FlushSecondsInterval(seconds);
	}
	
	
	/// <summary>
	/// Defaults to true. Log to disk when passing a checkpoint.
	/// </summary>
	/// <param name='enabled'>
	/// Enable or disable logging at checkpoints.
	/// </param>
	public static void LogOnCheckpoint(bool enabled) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_LogOnCheckpoint(enabled);
	}
	
	/// <summary>
	/// Defaults to true. Prints remote logs to Apple System Log.
	/// </summary>
	/// <param name='enabled'>
	/// Enable or disable logging to the console.
	/// </param>
	public static void EnableLogToConsole(bool enabled) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_EnableLogToConsole(enabled);
	}
	
	/// <summary>
	/// Defaults to true. Sends remote logs to STDERR when debugger is attached.
	/// </summary>
	/// <param name='enabled'>
	/// Enable or disable logging to STDERR.
	/// </param>
	public static void EnableSTDErrLogger(bool enabled) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_EnableSTDErrLogger(enabled);
	}	
	
	/// <summary>
	/// Defaults to true. If set to false, crash handlers are never installed.
	/// </summary>
	/// <param name='enabled'>
	/// Enable or disable crash reporting.
	/// </param>
	public static void ReportCrashes(bool enabled) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_ReportCrashes(enabled);
	}		
	
	/// <summary>
	/// Defaults to false. Setting to true stops remote logs from being sent when sessions end. 
	/// They would only be sent in the event of a crash.
	/// </summary>
	/// <param name='enabled'>
	/// Enable or disable sending of logs.
	/// </param>
	public static void SendLogOnlyOnCrash(bool enabled) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_SendLogOnlyOnCrash(enabled);
	}
	
	/// <summary>
	/// Defaults to 30. This is the amount of time a user can leave the app for and still continue
	/// the same session when they come back. If they are away from the app for longer, a new session 
	/// is created when they come back. Change to 0 to turn off.
	/// </summary>
	/// <param name='seconds'>
	/// Number of seconds to keep the current session alive.
	/// </param>
	public static void SessionKeepAliveTimeout(int seconds) 
	{
		if ( Application.platform == RuntimePlatform.IPhonePlayer )
			_SessionKeepAliveTimeout(seconds);
	}
	
	#endregion
}
