// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/* Set the width of the side navigation to 250px */
function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
  }
  
  /* Set the width of the side navigation to 0 */
  function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
  }
document.getElementById('selectAll').addEventListener('change', function() {
  const checkboxes = document.querySelectorAll('input[name="selectedRows[]"]');
  checkboxes.forEach(checkbox => {
    checkbox.checked = this.checked;
  });
});

// Example: Add event listener to individual row checkboxes for highlighting
document.querySelectorAll('input[name="selectedRows[]"]').forEach(checkbox => {
   checkbox.addEventListener('change', function(){
     const row = this.closest('tr'); // Find the parent row
     row.classList.toggle('selected', this.checked); // Toggle CSS class based on checkbox
   });
 });

document.getElementById('patientIntakeForm').addEventListener('submit', function(event) {
    event.preventDefault();
    alert('Form submitted successfully! In a real implementation, this would be sent to the server.');
    // In a real-world scenario, you would send the form data to a server here
});
