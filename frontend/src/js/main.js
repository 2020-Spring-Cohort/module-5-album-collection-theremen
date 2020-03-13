import Header from './components/Header';
import Footer from './components/Footer';
import Homepage from './components/Homepage';
import ViewArtists from './components/ViewArtists';
import ViewAlbums from './components/ViewAlbums';
import AboutUs from './components/AboutUs';

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
    const ourMusic = document.querySelector('#our-music')
    ourMusic.addEventListener('click', function(){
        alert('Our Music clicked')
        document.querySelector('#app').innerHTML = ViewArtists(artists)
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