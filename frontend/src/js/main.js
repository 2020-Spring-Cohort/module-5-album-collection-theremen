import Header from './components/Header';
import Footer from './components/Footer';
import Homepage from './components/Homepage';
import ViewArtists from './components/ViewArtists';

pageBuild()

function pageBuild(){
    header()
    homepage()
    footer()
    ourMusic()
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