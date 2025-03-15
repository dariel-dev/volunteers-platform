document.getElementById('volunteerButton').addEventListener('click', function () {
    document.querySelector('.welcome-section').style.display = 'none';
    let content = document.getElementById('content');
    content.style.display = 'block';
    content.innerHTML = `
        <div class="volunteer-section volunteer-theme">
            <h2>Join as a Volunteer</h2>
            <img src="https://www.caringnetwork.com/wp-content/uploads/2023/01/10-Benefits-of-Volunteering-Your-Time-Regularly-2880w.webp" alt="Benefits of Volunteering">
            <p>Discover opportunities to give back to the community. As a volunteer, you can make a difference by engaging in meaningful activities and supporting various causes.</p>
        </div>
    `;
});

document.getElementById('providerButton').addEventListener('click', function () {
    document.querySelector('.welcome-section').style.display = 'none';
    let content = document.getElementById('content');
    content.style.display = 'block';
    content.innerHTML = `
        <div class="provider-section">
            <h2>List Your Opportunity</h2>
            <img src="https://gettingattention.org/wp-content/uploads/2023/06/Volunteer-Recruitment_Feature-1.jpg" alt="Volunteer Opportunity">
            <p>Provide your organization's opportunities for volunteers and recruit skilled individuals to help. List your needs and get the right people involved!</p>
        </div>
    `;
});
