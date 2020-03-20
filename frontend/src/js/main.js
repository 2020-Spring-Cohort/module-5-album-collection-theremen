import Header from './components/Header';
import Footer from './components/Footer';
import Homepage from './components/Homepage';
import ViewArtists from './components/ViewArtists';
import ViewAlbums from './components/ViewAlbums';
import AboutUs from './components/AboutUs';
import apiActions from './api/apiActions';


export default pageBuild

function pageBuild(){
    header()
    homepage()
    footer()
    viewArtists()
    viewAlbums()
    aboutUs()
}

function header() {
    const header = document.querySelector('#header')
    header.innerHTML = Header()
}

function footer() {
    const footer = document.querySelector('#footer')
    footer.innerHTML = Footer()
}

function homepage() {
    const homePageButton = document.querySelector('#home')
    homePageButton.addEventListener('click', function(){
        document.querySelector('#app').innerHTML = Homepage()
    })
}

function viewArtists() {
    const app = document.querySelector('#app');
    const ourMusic = document.querySelector('#our-music')
    ourMusic.addEventListener('click', function(){
        apiActions.getRequest("https://localhost:44313/api/Artist",
        artists => {
            console.log(artists);
            app.innerHTML = ViewArtists(artists);
        })
    })
    app.addEventListener('click', function(){
        if(event.target.classList.contains('add-artist__submit')){
            const artistName = event.target.parentElement.querySelector('.add-artist__artistName').value;
            const artistImage = event.target.parentElement.querySelector('.add-artist__artistImage').value;
            const artistHometown = event.target.parentElement.querySelector('.add-artist__artistHometown').value;

            var requestBody = {
                Name: artistName,
                Image: artistImage,
                Hometown: artistHometown
            }
            apiActions.postRequest(
                "https://localhost:44313/api/Artist",
                requestBody,
                artists => {
                    console.log("Artists returned from backend")
                    console.log(artists);
                    app.innerHTML = ViewArtists(artists)
                }
            )
        }
    })

}

function aboutUs() {
    const aboutUs = document.querySelector('#about-us')
    aboutUs.addEventListener('click', function(){
        document.querySelector('#app').innerHTML = AboutUs()
    })
}

function viewAlbums() {
    const artist = document.querySelectorAll('.artist').forEach(artist => {
        artist.addEventListener('click', function(){
            document.querySelector('#view-albums').innerHTML = ViewAlbums()
        })
    })
}