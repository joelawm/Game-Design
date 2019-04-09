/* Core.h

Created by Joe Meyer on 1/29/18.
Copyright (c) 2019 Lost Instinct. All rights reserved.

Purpose: This file shows the macros for the windows side of the engine.
*/
#pragma once

#ifdef SS_PLATFORM_WINDOWS
	#ifdef SS_BUILD_DLL
		#define STARSIDE_API _declspec(dllexport)
	#else 
		#define STARSIDE_API _declspec(dllimport)
	#endif
#else
	#error Hazel only supports window!
#endif