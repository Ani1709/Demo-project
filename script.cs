// Function to update the preview area
function upDate(previewPic) {

    // Check whether the function is working
    console.log("upDate function is triggered");

    // Print the alt text
    console.log("Alt:", previewPic.alt);

    // Print the image source
    console.log("Source:", previewPic.src);


    // Get the div with id="image"
    let image = document.getElementById("image");


    // Change the text
    image.innerHTML = previewPic.alt;


    // Change the background image
    image.style.backgroundImage = "url('" + previewPic.src + "')";
}


// Function to undo the preview
function undo() {

    // Check whether the function is working
    console.log("undo function is triggered");


    // Get the div with id="image"
    let image = document.getElementById("image");


    // Remove the background image
    image.style.backgroundImage = "url('')";


    // Restore the original text
    image.innerHTML = "Hover over an image below to display here.";
}