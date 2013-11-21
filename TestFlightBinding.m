#import "TestFlight.h"

void _AddCustomEnvironmentInformation(const char *token, const char *key)
{
    [TestFlight addCustomEnvironmentInformation:[NSString stringWithUTF8String:token] forKey:[NSString stringWithUTF8String:key]];
}

void _TakeOff(const char* token) {
    [TestFlight takeOff:[NSString stringWithUTF8String:token]];
}

void _PassCheckpoint(const char* checkpoint) {
    [TestFlight passCheckpoint:[NSString stringWithUTF8String:checkpoint]];
}

void _SubmitFeedback(const char* feedback) {
    [TestFlight submitFeedback:[NSString stringWithUTF8String:feedback]];
}

void _Log(const char* message) {
    TFLog(@"%@", [NSString stringWithUTF8String:message]);
}

void _DisableInAppUpdates(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:TFOptionDisableInAppUpdates]];
}

void _FlushSecondsInterval(int seconds) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithInt:seconds] forKey:TFOptionFlushSecondsInterval]];
}

void _LogOnCheckpoint(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:TFOptionLogOnCheckpoint]];
}

void _EnableLogToConsole(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:TFOptionLogToConsole]];
}

void _EnableSTDErrLogger(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:TFOptionLogToSTDERR]];
}

void _ReinstallCrashHandlers(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:TFOptionReinstallCrashHandlers]];
}

void _ReportCrashes(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:TFOptionReportCrashes]];
}

void _SendLogOnlyOnCrash(BOOL enabled) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithBool:enabled] forKey:TFOptionSendLogOnlyOnCrash]];
}

void _SessionKeepAliveTimeout(int seconds) {
    [TestFlight setOptions:[NSDictionary dictionaryWithObject:[NSNumber numberWithInt:seconds] forKey:TFOptionSessionKeepAliveTimeout]];
}


