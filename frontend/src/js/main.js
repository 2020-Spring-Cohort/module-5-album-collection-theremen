import Header from './components/Header';
import Footer from './components/Footer';
import Homepage from './components/Homepage';
import ViewArtists from './components/ViewArtists';
import ViewAlbums from './components/ViewAlbums';

export default pageBuild

function pageBuild(){
    header()
    homepage()
    footer()
    ourMusic()
    viewAlbums()
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
    const homepageDescription = document.querySelector('#homepage-description')
    homepageDescription.innerHTML = Homepage()
}

function ourMusic() {
    const ourMusic = document.querySelector('#our-music')
    ourMusic.addEventListener('click', function(){
        document.querySelector('#view-artists').innerHTML = ViewArtists()
    })
}

function viewAlbums() {
    const artist = document.querySelectorAll('.artist').forEach(artist => {
        artist.addEventListener('click', function(){
            document.querySelector('#view-albums').innerHTML = ViewAlbums()
        })
    })
}