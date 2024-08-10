

using StateDesignPattern.Model;

class Program
{
    static void Main(string[] args)
    {
        // Initialize with Red state
        TrafficLightContext trafficLight = new TrafficLightContext(new RedState());

        // Cycle through the states
        trafficLight.Request(); // Output: Traffic light is now Red. Switching to Green.
        trafficLight.Request(); // Output: Traffic light is now Green. Switching to Yellow.
        trafficLight.Request(); // Output: Traffic light is now Yellow. Switching to Red.
    }
}