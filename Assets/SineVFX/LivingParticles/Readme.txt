Living Particles
Version 1.4 Audio + SRP Update (02.11.2019)

WHATS NEW IN 1.4:

- New Audio Reactive Particles, check the DemoSceneAudio
- HDRP Shaders converted to ShaderGraph and now editable
- LWRP Shaders updated

SETUP FOR AUDIO REACTIVE EFFECTS:

- Drag and Drop Effects from a Prefab folder, make sure it has "Living Particles Audio Module" component and assign a desired position to a "L Pa Source" variable
- Also check the new Materials parameters with keyword "Audio..."
- Add "Living Particles Audio Source" to your audio source GameObject

Audio Source Script parameters:

Buffer Initial Decrease Speed - "Dropping" particle speed
Buffer Decrease Speed Multiply - Speed will be multiplied by this value every frame
Freq Bands Power - Multiply the power of the spectrum
Audio Profile Initial Value - Initial maximum value for the spectrum, you can play with this parameter, it will affect how quickly the final spectrum result will smoothen out
Audio Profile Decreasing - Decrease the value above every frame by Audio Profile Decreasing Speed
Number Of Bands - chouse between 8 and 16 bands textures

Material parameters:

Audio Spectrum - controls the power of an initial spectrum texture
Audio Mask - creates a radial mask
Audio Amplitude - affects all particles based on an average amplitude parameter

WHATS NEW IN 1.3:

- HDRP AND LWRP Packages, you can find and unpack them in "LivingParticles/Packages/SRP" folder. Minimum Unity version is 2019.1 and SRP 5.x and above
- GPU Shaders for Standart Renderer, you can find them in "LivingParticles/Packages/GPU". Minimum Unity vesrion is 2018.1

IMPORTANT NOTES:

- Turn on "HDR" on your Camera, Shaders requires it
- This VFX Asset looks much better in "Linear Rendering", but there is also optimized Prefabs for "Gamma Rendering" Mode
- Image Effects are necessary in order to make a great looking game, as well as our asset. Be sure you using "Tone Mapping" and "Bloom"
- We also recommend using Deferred Rendering for better performance


HOW TO USE:

First of all, check for Demo Scene in Scenes folder. Also, there is a Prefabs folder with complete effects.
Just Drag and Drop prefabs from "Prefabs" folder into your scene, then assign your affector GameObject in "Living Particle Controller" component.
We made all Shaders very tweakable, so you can create your own unique effects. If you want to use Ground Particles on a vertical surface, please check the XY UV and ZY UV properties of the material.

ARRAY SHADERS:

If you planning to use more then one object to affect your particles, you need to use array shader variants. You can create an array variant from a regular prefab very easily.
Simply change the script from "LivingParticleController" to "LivingParticleArrayController", then assign all of your objects to it. And finally, change the
shader of a material to the one that has an "Array" in its name.

MORPH SHADERS:

In version 1.2 the new morph shader was added. It uses the morph textures to morph mesh particles. A couple of new properties was added to these shaders.
Most of the other properties remain the same.

Flip Morph/Emission/Offset Mask - Flips the values of the mask
Morph Main - Morph texture for vertex offset
Morph Normal - Morph normal texture for correct normals after using offset
Distance Remap - Remap the lower value of the distance map, use it to adjusting the distance mask


SHADERS CONTROL:

Final Color - Emission color of affected particles
Final Color 2 - Emission color of unaffected particles
Final Power - Final brightness of the image, you need to lower this value if you using "Gamma Rendering" Mode
Final Mask Multiply - Multiply result mask by this value

Ramp Enabled - Use ramp gradient to colorize particles
Ramp - Gradient texture, located in "VFXTextures" folder

Distance - Affected particles distance
Distance Power - Multiply distance mask by this value
Offset Power - Offsetting particle towards Affector

Camera Fade - Fade particles when near Camera
Clode Fade - Fade particles when near Affector
Vertex Distortion - Distort vertices of particle mesh, suitable for paper or leafs effects

Affector Count - If you use more than one Affector, make sure that this value is the same as in the "Living Particle Array Controller" component
Noise - Values for creating a noise mask, used in floor particles




Support email "sinevfx@gmail.com"