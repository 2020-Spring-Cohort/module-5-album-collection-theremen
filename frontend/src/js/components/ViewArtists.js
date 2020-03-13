export default function ViewArtists(artists) {
    return `
    <ul id="view-artists">
        ${artists.map(artist => {
            return `
            <li class="artist">${artist.Name}</li>
            `
        })}
    </ul>
    `
}