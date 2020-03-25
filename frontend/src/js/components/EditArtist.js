export default function EditArtist(artist){
    return `
    <section class="content__artist">
        <h4>${artist.name}</h4>
    </section>
    
    <section class="update-artist">
        <input class="update-artist__name" type="text" value="${artist.name}">
        <input class="update-artist__image" type="text" value="${artist.image}">
        <input class="update-artist__hometown" type="text" value="${artist.hometown}">
        <input class="update-artist__id" type="hidden" value="${artist.artistId}">
        <button class="update-artist__submit">Save Changes</button>
    </section>
`;
}