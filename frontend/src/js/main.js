import Header from './components/Header';
import Footer from './components/Footer';
import Homepage from './components/Homepage';
import ViewArtists from './components/ViewArtists';
import ViewAlbums from './components/ViewAlbums';
import AboutUs from './components/AboutUs';
import apiActions from './api/apiActions';
import EditArtist from './components/EditArtist';



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

    app.addEventListener("click", function(){
        if(event.target.classList.contains('edit-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.artist__id').value;
            console.log(artistId);
            apiActions.getRequest(
                `https://localhost:44313/api/Artist/${artistId}`,
                artistEdit => {
                    console.log(artistEdit);
                    app.innerHTML = EditArtist(artistEdit);
                  }
            )
        }
    })

    app.addEventListener('click', function(){
        if(event.target.classList.contains('update-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.update-artist__id').value;
            const artistName = event.target.parentElement.querySelector('.update-artist__name').value
            const artistImage = event.target.parentElement.querySelector('.update-artist__image').value
            const artistHometown = event.target.parentElement.querySelector('.update-artist__hometown').value

            const artistData = {
                artistId: artistId,
                name: artistName,
                image: artistImage,
                hometown: artistHometown
            };
            console.log(artistData)

            apiActions.putRequest(
                `https://localhost:44313/api/Artist/${artistId}`,
                artistData,
                artists => {
                    app.innerHTML = ViewArtists(artists);
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