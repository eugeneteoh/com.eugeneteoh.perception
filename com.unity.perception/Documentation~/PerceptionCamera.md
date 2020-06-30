# The Perception Camera component
The Perception Camera component ensures the attached [Camera](https://docs.unity3d.com/Manual/class-Camera.html) runs at deterministic rates and captures RGB and other Camera-related ground truth to the [JSON dataset](Schema/Synthetic_Dataset_Schema.md) using [DatasetCapture](DatasetCapture.md). It supports HDRP and URP.

<img src="images/PerceptionCamera.PNG" align="middle"/>

## Properties
| Property: | Function: |
|--|--|
| Description | A description of the camera to be registered in the JSON dataset. |
| Period | The amount of simulation time in seconds between frames for this camera. For more on sensor scheduling, see [DatasetCapture](DatasetCapture.md). |
| Start Time | The simulation time at which to run the first frame. This time will offset the period, useful for allowing multiple cameras to run at the right times relative to each other. |
| Capture Rgb Images | When this is checked, RGB images will be captured as PNG files in the dataset each frame. |
| Produce Segmentation Images| When this is checked at startup, semantic segmentation images will be captured as PNG files in the dataset each frame. Pixel colors are derived from the [Labeling](GroundTruth-Labeling.md) components attached to the GameObjects and the Labeling Configuration specified on the Perception Camera. |
|Produce Object Count Annotations| When this is checked at startup, a metric reporting object counts for each label in the Labeling Configuration will be added to the dataset each frame. |
|Object Count Id| The ID to use in the dataset for the Object Count metric. |
|Produce Bounding Box Annotations| When this is checked at startup, an annotation reporting 2D bounding boxes of each labeled GameObject will be added to the dataset each frame. |
|Bounding Box Id| The ID to use in the dataset for the Bounding Box annotation.|
|Produce Rendered Object Info Metric|When this is checked at startup, a metric reporting visible pixels, instance ID and resolved label will be reported for each object each frame. Labels are resolved using the Labeling Configuration. |
|Rendered Object Info Id| The ID to use in the dataset for the Rendered Object Info annotation.|
|Bounding Box Origin|Whether the X/Y values reported for bounding boxes should start at the bottom-left or top-left of the object in the frame. |
|Labeling Configuration| The Labeling Configuration used to resolve each object to a single label, label ID, or semantic segmentation pixel value in the ground truth generated by this Perception Camera.|