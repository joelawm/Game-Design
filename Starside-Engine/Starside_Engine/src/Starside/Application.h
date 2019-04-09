/* Application.h

Created by Joe Meyer on 1/29/18.
Copyright (c) 2019 Lost Instinct. All rights reserved.

Purpose: This is the header file for the Starside application engine.
*/
#pragma once

#include "core.h";

namespace Starside {

	
	class STARSIDE_API Application
	{
	public:
		Application();
		virtual ~Application();

		//Starside functions
		void Run();

	};
}

