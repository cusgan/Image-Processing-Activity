# Image Processing Activities

This repository contains Image Processing Activity files for the **Intelligent Systems 1** course.

## 1. Dynamic Image Processing (DIP)

### Part 1: Basic DIP

Features:
1. **Basic Copy:** Scans all the input image's pixels and copies each pixel into another empty Bitmap.
2. **Grayscale:** Converts the input image's colors into different tones of gray by avering the color properties of each pixel.
3. **Color Inversion:** Creates a negative version of the screen colors, where light colors become dark, dark colors become light, and colors are inverted.
4. **Histogram:** Scans all the input image's pixels, counts all the levels of different colors, and creates an array of intensities. Results in higher magnitudes toward 255 level for light colored images, and higher magnitudes toward 0 level for dark colored images.
5. **Sepia:** Converts the input image's colors into different reddish tones, based on sepia print toning in photography.

### Part 2: Image Subtraction (Greenscreening)

Takes two input images, one background and one foreground (with greenscreen), and subtracts the two creating a greenscreened image.

## 2. DIP Convolution Matrix

Convolution is the treatment of a matrix by another one which is called “kernel”. The Convolution Matrix filter uses a first matrix which is the Image to be treated. The image is a bi-dimensional collection of pixels in rectangular coordinates. The used kernel depends on the effect you want. 

## 3. Coin Counting

Counts the total value of the coins displayed on the given image.
