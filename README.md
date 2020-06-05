# Samples

## S01: Basics

This is a simple sample of how to bind a View to a ViewModel's Reactive Property. 

```csharp
public sealed class TestBehaviour : MonoBehaviour
{
    private readonly IReactiveProperty<float> _time = new ReactiveProperty<float>();

    private void Start()
    {
        // Bind the View to the Property
        GetComponent<TextView>().Bind(_time);
    }

    private void Update()
    {
        // Update the Property value
        _time.Value += Time.deltaTime;
    }
}
```

Run the Scene to see how the View is updating every frame when the Reactive Property value updates.

## S02: RTS UI

This is a more complex sample of how to create nested Views and set/bind values of ViewModels.

The video below shows the functionality of the sample.

[![Video Sample](https://img.youtube.com/vi/YAnY434Kx3g/0.jpg)](https://www.youtube.com/watch?v=YAnY434Kx3g "Video Sample")
