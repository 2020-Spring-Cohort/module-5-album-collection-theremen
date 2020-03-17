export default function ViewArtists(artists) {
    return `
    <ul id="view-artists">
        ${artists.map(artist => {
            return `
            <li class="artist">${artist.name}</li>
            `
        })}
    </ul>
    `
}