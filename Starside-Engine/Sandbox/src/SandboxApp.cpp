/* SandboxApp.cpp

Created by Joe Meyer on 1/29/18.
Copyright (c) 2019 Lost Instinct. All rights reserved.

Purpose: This a app for the Starside engine, one purpose is to display
a sandbox for the user to mess around with.
*/

#include <Starside.h>

class Sandbox : public Starside::Application
{
public:
	Sandbox()
	{

	}

	~Sandbox()
	{

	}
};

//Main application for users to launch sandbox app.
int main()
{
	Sandbox* sandbox = new Sandbox();
	sandbox->Run();
	delete sandbox;
}